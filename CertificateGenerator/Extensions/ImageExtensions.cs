using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CertificateGenerator.Extensions
{
    internal static class ImageExtensions
    {
        public static Image RoundCorners(this Image startImage, int cornerRadius)
        {
            cornerRadius *= 2;
            Bitmap roundedImage = new Bitmap(startImage.Width, startImage.Height);
            using Graphics graphics = Graphics.FromImage(roundedImage);
            graphics.Clear(Color.Transparent);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Brush brush = new TextureBrush(startImage);
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top left corner
            graphicsPath.AddArc(startImage.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top right corner
            graphicsPath.AddArc(startImage.Width - cornerRadius, startImage.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom right corner
            graphicsPath.AddArc(0, startImage.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom left corner

            graphics.FillPath(brush, graphicsPath);
            return roundedImage;
        }

        public static Image ResizeImage(this Image image, int newWidth, int newHeight)
        {
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using Graphics graphics = Graphics.FromImage(resizedImage);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            return resizedImage;
        }

        public static Image ConvertPngToJpg(this Image pngImage)
        {
            Bitmap jpgImage = new Bitmap(pngImage.Width, pngImage.Height);
            using Graphics graphics = Graphics.FromImage(jpgImage);
            graphics.Clear(Color.White);
            graphics.CompositingMode = CompositingMode.SourceOver;
            graphics.DrawImage(pngImage, 0, 0, pngImage.Width, pngImage.Height);
            using MemoryStream jpgStream = new MemoryStream();
            jpgImage.Save(jpgStream, ImageFormat.Jpeg);
            return Image.FromStream(jpgStream);
        }

        public static MemoryStream ReCompressImage(this MemoryStream inputMemoryStream, long quality = 100)
        {
            if (inputMemoryStream == null || inputMemoryStream.Length == 0)
            {
                throw new ArgumentException("Input memory stream is null or empty.", nameof(inputMemoryStream));
            }

            // Create a new Bitmap object from the input memory stream
            using var inputImage = new Bitmap(inputMemoryStream);
            // Create a new memory stream to hold the compressed image data
            using var outputMemoryStream = new MemoryStream();
            // Create an EncoderParameters object to specify the compression quality
            var encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);

            // Get the appropriate image codec for the output format (e.g., JPEG)
            var codecInfo = GetEncoderInfo("image/jpeg"); // Change to the desired output format

            if (codecInfo == null)
            {
                throw new Exception("Failed to find encoder for the specified image format.");
            }

            // Save the compressed image data to the output memory stream
            inputImage.Save(outputMemoryStream, codecInfo, encoderParameters);

            // Reset the position of the memory stream to the beginning
            outputMemoryStream.Seek(0, SeekOrigin.Begin);

            // Return the compressed image data as a memory stream
            return outputMemoryStream;
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            foreach (var codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}

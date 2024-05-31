using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using CertificateGenerator.Strings;
using CertificateGenerator.Utility_Side_Classes;

namespace CertificateGenerator.Extensions
{
    internal static class ImageExtensions
    {
        private static AppStrings _appStrings;

        public static void InjectDependency(AppStrings strings)
        {
            _appStrings = strings;
        }
        public static Image RoundCorners(this Image startImage, int cornerRadius)
        {
            try
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
            catch (Exception e)
            {
                Alerter.HandleException(e,_appStrings.ErrorRoundImage,false);
                return startImage;
            }

        }

        public static Image ResizeImage(this Image image, int newWidth, int newHeight)
        {
            try
            {
                Bitmap resizedImage = new Bitmap(newWidth, newHeight);
                using Graphics graphics = Graphics.FromImage(resizedImage);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
                return resizedImage;
            }
            catch (Exception e)
            {
                Alerter.HandleException(e,_appStrings.ErrorResizeImage,false);
                return image;
            }
        }

        public static Image ConvertPngToJpg(this Image pngImage)
        {
            try
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
            catch (Exception e)
            {
                Alerter.HandleException(e,_appStrings.ErrorConvertImage,false);
                return pngImage;
            }
        }


    }
}

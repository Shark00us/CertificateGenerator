using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CertificateGenerator.Utility_Side_Classes;

public class ImageCompressor
{
    public MemoryStream ReCompressImage(MemoryStream inputMemoryStream, string mimeType = "image/jpeg",long quality = 100)
    {
        if (inputMemoryStream == null || inputMemoryStream.Length == 0)
        {
            throw new ArgumentException("Input memory stream is null or empty.", nameof(inputMemoryStream));
        }

        using var inputImage = new Bitmap(inputMemoryStream);
        using var outputMemoryStream = new MemoryStream();
        var encoderParameters = new EncoderParameters(1);
        encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
        var codecInfo = GetEncoderInfo(mimeType);
        if (codecInfo == null)
        {
            throw new Exception("Failed to find encoder for the specified image format.");
        }

        inputImage.Save(outputMemoryStream, codecInfo, encoderParameters);
        outputMemoryStream.Seek(0, SeekOrigin.Begin);
        return outputMemoryStream;
    }

    private ImageCodecInfo GetEncoderInfo(string mimeType)
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
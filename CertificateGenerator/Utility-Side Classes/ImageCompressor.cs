using CertificateGenerator.Strings;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace CertificateGenerator.Utility_Side_Classes;

public class ImageCompressor
{
    private readonly AppStrings _appStrings;

    public ImageCompressor(AppStrings appStrings)
    {
        _appStrings = appStrings;
    }
    public MemoryStream? ReCompressImage(MemoryStream? inputMemoryStream, string mimeType = "image/jpeg", long quality = 100)
    {
        try
        {
            using var inputImage = new Bitmap(inputMemoryStream);
            using var outputMemoryStream = new MemoryStream();
            var encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
            var codecInfo = GetEncoderInfo(mimeType);
            inputImage.Save(outputMemoryStream, codecInfo, encoderParameters);
            outputMemoryStream.Seek(0, SeekOrigin.Begin);
            return outputMemoryStream;

        }
        catch (Exception ex)
        {
            Alerter.HandleException(ex, _appStrings.ErrorReCompressImage, true);
            return inputMemoryStream;
        }
    }

    private static ImageCodecInfo GetEncoderInfo(string mimeType)
    {
        var codecs = ImageCodecInfo.GetImageEncoders();
        return codecs.FirstOrDefault(codec => codec.MimeType == mimeType);
    }
}
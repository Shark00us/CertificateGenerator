namespace CertificateGenerator
{
    internal static class OtherExtensions
    {

        public static string[] ArabicNumberToHindiNumbers(this string[] controlsTexts)
        {
            for (int i = 0; i < controlsTexts.Length; i++)
            {
                controlsTexts[i] = controlsTexts[i]
                    .Replace('0', '۰')
                    .Replace('1', '۱')
                    .Replace('2', '۲')
                    .Replace('3', '۳')
                    .Replace('4', '۴')
                    .Replace('5', '۵')
                    .Replace('6', '۶')
                    .Replace('7', '۷')
                    .Replace('8', '۸')
                    .Replace('9', '۹');
            }

            return controlsTexts;
        }


    }
}

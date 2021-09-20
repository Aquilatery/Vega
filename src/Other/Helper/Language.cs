using Setting;
using System.Globalization;
using static Enum.Enum;

namespace Helper
{
    internal class Language
    {
        private static readonly CultureInfo Detected = CultureInfo.CurrentCulture;

        public static Languages Detect
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(Detected.TwoLetterISOLanguageName))
                    {
                        return Constant.DefaultLanguage;
                    }
                    else
                    {
                        return Detected.TwoLetterISOLanguageName.ToUpper(CultureInfo.CurrentCulture) switch
                        {
                            "TR" => Languages.TR,
                            _ => Constant.DefaultLanguage,
                        };
                    }
                }
                catch
                {
                    return Constant.DefaultLanguage;
                }
            }
        }
    }
}

using Helper;
using System.Drawing;
using static Enum.Enum;

namespace Setting
{
    internal class Variable
    {
        public static bool Exit = true;

        public static Languages ActiveLanguage => Language.Detect;

        public static BackgroundType BackgroundType => BackgroundType.Image;

        public static Color BackgroundColor => Color.Black;

        public static string BackgroundPath => string.Empty;

        public static TaskbarAlignment TaskbarAlignment => TaskbarAlignment.Centre;

        public static TaskbarType TaskbarType => TaskbarType.Gradient;

        public static Color[] TaskbarColor => new Color[5]
        {
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(25, 25, 25),
            Color.Black,
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(25, 25, 25)
        };
    }
}
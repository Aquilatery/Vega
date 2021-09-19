using System.Windows.Forms;

namespace Helper
{
    internal class Resolution
    {
        public static int BoundsWidth => Screen.PrimaryScreen.Bounds.Width;

        public static int BoundsHeight => Screen.PrimaryScreen.Bounds.Height;

        public static int WorkingWidth => Screen.PrimaryScreen.WorkingArea.Width;

        public static int WorkingHeight => Screen.PrimaryScreen.WorkingArea.Height;
    }
}
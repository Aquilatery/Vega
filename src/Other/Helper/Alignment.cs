using System.Drawing;
using System.Windows.Forms;

namespace Helper
{
    internal class Alignment
    {
        public static Point Center(Control BaseControl, Control TargetControl)
        {
            return new Point((BaseControl.Width / 2) - (TargetControl.Width / 2), (BaseControl.Height / 2) - (TargetControl.Height / 2));
        }

        public static Point CenterLeft(Control BaseControl, Control TargetControl)
        {
            return new Point(0, (BaseControl.Height / 2) - (TargetControl.Height / 2));
        }

        public static Point CenterRight(Control BaseControl, Control TargetControl)
        {
            return new Point(BaseControl.Width - TargetControl.Width, (BaseControl.Height / 2) - (TargetControl.Height / 2));
        }

        public static Point TopCenter(Control BaseControl, Control TargetControl)
        {
            return new Point((BaseControl.Width / 2) - (TargetControl.Width / 2), 0);
        }

        public static Point TopLeft(Control BaseControl = null, Control TargetControl = null)
        {
            return new Point(0, 0);
        }

        public static Point TopRight(Control BaseControl, Control TargetControl)
        {
            return new Point(BaseControl.Width - TargetControl.Width, 0);
        }

        public static Point BottomCenter(Control BaseControl, Control TargetControl)
        {
            return new Point((BaseControl.Width / 2) - (TargetControl.Width / 2), BaseControl.Height - TargetControl.Height);
        }

        public static Point BottomLeft(Control BaseControl, Control TargetControl)
        {
            return new Point(0, BaseControl.Height - TargetControl.Height);
        }

        public static Point BottomRight(Control BaseControl, Control TargetControl)
        {
            return new Point(BaseControl.Width - TargetControl.Width, BaseControl.Height - TargetControl.Height);
        }
    }
}
using System.Windows.Forms;

namespace Util
{
    internal class Aligner
    {
        public static void Center(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.Center(BaseControl, TargetControl);
        }

        public static void CenterLeft(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.CenterLeft(BaseControl, TargetControl);
        }

        public static void CenterRight(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.CenterRight(BaseControl, TargetControl);
        }

        public static void TopCenter(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.TopCenter(BaseControl, TargetControl);
        }

        public static void TopLeft(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.TopLeft(BaseControl, TargetControl);
        }

        public static void TopRight(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.TopRight(BaseControl, TargetControl);
        }

        public static void BottomCenter(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.BottomCenter(BaseControl, TargetControl);
        }

        public static void BottomLeft(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.BottomLeft(BaseControl, TargetControl);
        }

        public static void BottomRight(Control BaseControl, Control TargetControl)
        {
            TargetControl.Location = Helper.Alignment.BottomRight(BaseControl, TargetControl);
        }
    }
}
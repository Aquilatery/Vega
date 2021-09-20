using System.Windows.Forms;

namespace Util
{
    internal class Changer
    {
        public static void Appearance(Form BaseForm)
        {
            foreach (Form Forms in Application.OpenForms)
            {
                if (Forms != BaseForm)
                {
                    Forms.Opacity = 0;
                }
            }
        }
    }
}
using Setting;
using System;
using System.Drawing;
using System.Windows.Forms;
using Util;
using static Enum.Enum;

namespace Vega.UC
{
    public partial class Taskbar : UserControl
    {
        public Taskbar()
        {
            InitializeComponent();
        }

        private void Taskbar_Load(object sender, EventArgs e)
        {
            Refresh();
            Background();
            Alignment();
        }

        private void Background()
        {
            switch (Variable.TaskbarType)
            {
                case TaskbarType.Color:
                    parrotGradientPanel1.BottomLeft = Variable.TaskbarColor[2];
                    parrotGradientPanel1.BottomRight = Variable.TaskbarColor[2];
                    parrotGradientPanel1.TopLeft = Variable.TaskbarColor[2];
                    parrotGradientPanel1.TopRight = Variable.TaskbarColor[2];
                    parrotGradientPanel1.PrimerColor = Variable.TaskbarColor[2];
                    break;
                default:
                    parrotGradientPanel1.BottomLeft = Variable.TaskbarColor[0];
                    parrotGradientPanel1.BottomRight = Variable.TaskbarColor[1];
                    parrotGradientPanel1.TopLeft = Variable.TaskbarColor[2];
                    parrotGradientPanel1.TopRight = Variable.TaskbarColor[3];
                    parrotGradientPanel1.PrimerColor = Variable.TaskbarColor[4];
                    break;
            }
        }

        private void Alignment()
        {
            switch (Variable.TaskbarAlignment)
            {
                case TaskbarAlignment.Left:
                    parrotPictureBox1.Location = new Point(8, 8);
                    break;
                default:
                    Aligner.Center(panel1, parrotPictureBox1);
                    break;
            }
        }
    }
}
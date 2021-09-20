using Helper;
using Setting;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Util;
using static Enum.Enum;

namespace Vega.UI
{
    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            Size = new Size(Resolution.BoundsWidth, Resolution.BoundsHeight);

            Aligner.TopLeft(this, this);

            Background();

            Changer.Appearance(this);
        }

        private void Background()
        {
            switch (Variable.BackgroundType)
            {
                case BackgroundType.Color:
                    panel1.BackgroundImage = null;
                    panel1.BackColor = Variable.BackgroundColor;
                    break;
                default:
                    if (Variable.BackgroundPath == null || Variable.BackgroundPath == string.Empty)
                    {
                        panel1.BackgroundImage = Properties.Resources.Background;
                    }
                    else
                    {
                        if (File.Exists(Variable.BackgroundPath))
                        {
                            panel1.BackgroundImage = Image.FromFile(Variable.BackgroundPath);
                        }
                        else
                        {
                            panel1.BackgroundImage = Properties.Resources.Background;
                        }
                    }
                    break;
            }
        }

        private void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Variable.Exit)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

using Helper;
using Setting;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Util;

namespace Vega.UI
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            Size = new Size(Resolution.BoundsWidth, Resolution.BoundsHeight);

            Aligner.TopLeft(this, this);

            Aligner.Center(this, parrotCircleProgressBar1);

            new Screen().Show();
        }

        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Variable.Exit)
            {
                e.Cancel = true;
            }
        }
    }
}
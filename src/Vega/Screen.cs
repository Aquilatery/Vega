using Helper;
using System;
using System.Drawing;
using System.Windows.Forms;
using Util;

namespace Vega
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
        }

        private void Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}

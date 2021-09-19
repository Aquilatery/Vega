using System;
using System.Windows.Forms;

namespace Vega
{
    public partial class Bar : UserControl
    {
        public Bar()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
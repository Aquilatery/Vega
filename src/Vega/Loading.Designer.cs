
namespace Vega
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.parrotCircleProgressBar1 = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // parrotCircleProgressBar1
            // 
            this.parrotCircleProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parrotCircleProgressBar1.AnimationSpeed = 5;
            this.parrotCircleProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.parrotCircleProgressBar1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotCircleProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.parrotCircleProgressBar1.FilledColor = System.Drawing.Color.DodgerBlue;
            this.parrotCircleProgressBar1.FilledColorAlpha = 130;
            this.parrotCircleProgressBar1.FilledThickness = 40;
            this.parrotCircleProgressBar1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotCircleProgressBar1.IsAnimated = true;
            this.parrotCircleProgressBar1.Location = new System.Drawing.Point(181, 181);
            this.parrotCircleProgressBar1.Name = "parrotCircleProgressBar1";
            this.parrotCircleProgressBar1.Percentage = 33;
            this.parrotCircleProgressBar1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotCircleProgressBar1.ShowText = false;
            this.parrotCircleProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.parrotCircleProgressBar1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotCircleProgressBar1.TabIndex = 2;
            this.parrotCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.parrotCircleProgressBar1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotCircleProgressBar1.TextSize = 25;
            this.parrotCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.parrotCircleProgressBar1.UnfilledThickness = 24;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.ControlBox = false;
            this.Controls.Add(this.parrotCircleProgressBar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vega - Windows Explorer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loading_FormClosing);
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ParrotCircleProgressBar parrotCircleProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
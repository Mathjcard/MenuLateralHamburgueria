using System;

namespace MenulateralHamburgueria
{
    partial class frmCarrossel
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
            this.picCarrossel = new System.Windows.Forms.PictureBox();
            this.timerCarrossel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCarrossel)).BeginInit();
            this.SuspendLayout();
            // 
            // picCarrossel
            // 
            this.picCarrossel.Location = new System.Drawing.Point(-9, -31);
            this.picCarrossel.Name = "picCarrossel";
            this.picCarrossel.Size = new System.Drawing.Size(782, 536);
            this.picCarrossel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarrossel.TabIndex = 0;
            this.picCarrossel.TabStop = false;
            // 
            // timerCarrossel
            // 
            this.timerCarrossel.Interval = 3000;
            this.timerCarrossel.Tick += new System.EventHandler(this.TimerCarrossel_Tick);
            // 
            // frmCarrossel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 487);
            this.Controls.Add(this.picCarrossel);
            this.Name = "frmCarrossel";
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.picCarrossel)).EndInit();
            this.ResumeLayout(false);

        }

        private void timerCarrosel_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox picCarrossel;
        private System.Windows.Forms.Timer timerCarrossel;
    }
}
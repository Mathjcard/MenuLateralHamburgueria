namespace MenuLateralHamburgueria.Views
{
    partial class testeConexao
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
            this.btnTestaConexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestaConexao
            // 
            this.btnTestaConexao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestaConexao.Location = new System.Drawing.Point(12, 12);
            this.btnTestaConexao.Name = "btnTestaConexao";
            this.btnTestaConexao.Size = new System.Drawing.Size(776, 36);
            this.btnTestaConexao.TabIndex = 0;
            this.btnTestaConexao.Text = "Testar Conexão";
            this.btnTestaConexao.UseVisualStyleBackColor = true;
            this.btnTestaConexao.Click += new System.EventHandler(this.btnTestaConexao_Click);
            // 
            // testeConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestaConexao);
            this.Name = "testeConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "testeConexao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestaConexao;
    }
}
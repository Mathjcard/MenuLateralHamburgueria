namespace MenuLateralHamburgueria
{
    partial class frmConfig
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblConfiguracao = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.pnlTopo.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.Orange;
            this.pnlTopo.Controls.Add(this.lblConfiguracao);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(800, 67);
            this.pnlTopo.TabIndex = 4;
            // 
            // lblConfiguracao
            // 
            this.lblConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfiguracao.AutoSize = true;
            this.lblConfiguracao.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracao.Location = new System.Drawing.Point(183, 5);
            this.lblConfiguracao.Name = "lblConfiguracao";
            this.lblConfiguracao.Size = new System.Drawing.Size(435, 56);
            this.lblConfiguracao.TabIndex = 100001;
            this.lblConfiguracao.Text = "CONFIGURAÇÕES";
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.button1);
            this.pnlConteudo.Controls.Add(this.pnlCodigo);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 67);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(800, 383);
            this.pnlConteudo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Location = new System.Drawing.Point(10, 35);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 8);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 24);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Controls.Add(this.lblCodigo);
            this.pnlCodigo.Controls.Add(this.txtCodigo);
            this.pnlCodigo.Location = new System.Drawing.Point(12, 6);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(133, 58);
            this.pnlCodigo.TabIndex = 0;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlTopo);
            this.Name = "frmConfig";
            this.Text = "Configurações";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblConfiguracao;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}
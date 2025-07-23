namespace MenuLateralHamburgueria
{
    partial class frmCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUser));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SenhaBox = new System.Windows.Forms.CheckBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmeSenhaCadastro = new System.Windows.Forms.Label();
            this.btnCadastroUser = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsuarioNome = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Orange;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(792, 67);
            this.panelLogo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 56);
            this.label1.TabIndex = 100001;
            this.label1.Text = "FAÇA SEU CADASTRO";
            // 
            // SenhaBox
            // 
            this.SenhaBox.AutoSize = true;
            this.SenhaBox.BackColor = System.Drawing.Color.Transparent;
            this.SenhaBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaBox.ForeColor = System.Drawing.Color.Orange;
            this.SenhaBox.Location = new System.Drawing.Point(210, 506);
            this.SenhaBox.Name = "SenhaBox";
            this.SenhaBox.Size = new System.Drawing.Size(121, 20);
            this.SenhaBox.TabIndex = 26;
            this.SenhaBox.Text = "Visualizar Senha ";
            this.SenhaBox.UseVisualStyleBackColor = false;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(210, 465);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(380, 35);
            this.txtConfirmaSenha.TabIndex = 24;
            this.txtConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // lblConfirmeSenhaCadastro
            // 
            this.lblConfirmeSenhaCadastro.AutoSize = true;
            this.lblConfirmeSenhaCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmeSenhaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmeSenhaCadastro.ForeColor = System.Drawing.Color.Orange;
            this.lblConfirmeSenhaCadastro.Location = new System.Drawing.Point(206, 441);
            this.lblConfirmeSenhaCadastro.Name = "lblConfirmeSenhaCadastro";
            this.lblConfirmeSenhaCadastro.Size = new System.Drawing.Size(153, 21);
            this.lblConfirmeSenhaCadastro.TabIndex = 31;
            this.lblConfirmeSenhaCadastro.Text = "Confirme a Senha ";
            // 
            // btnCadastroUser
            // 
            this.btnCadastroUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroUser.FlatAppearance.BorderSize = 0;
            this.btnCadastroUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnCadastroUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUser.ForeColor = System.Drawing.Color.Orange;
            this.btnCadastroUser.Location = new System.Drawing.Point(337, 541);
            this.btnCadastroUser.Name = "btnCadastroUser";
            this.btnCadastroUser.Size = new System.Drawing.Size(133, 39);
            this.btnCadastroUser.TabIndex = 27;
            this.btnCadastroUser.Text = "Cadastrar";
            this.btnCadastroUser.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(210, 403);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(380, 35);
            this.txtSenha.TabIndex = 22;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Orange;
            this.lblSenha.Location = new System.Drawing.Point(209, 379);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 21);
            this.lblSenha.TabIndex = 30;
            this.lblSenha.Text = "Senha";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(210, 323);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(380, 35);
            this.txtNomeUser.TabIndex = 21;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Orange;
            this.lblCargo.Location = new System.Drawing.Point(208, 229);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(60, 21);
            this.lblCargo.TabIndex = 29;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(210, 253);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(380, 35);
            this.txtCargo.TabIndex = 20;
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.ForeColor = System.Drawing.Color.Orange;
            this.lblNomeUser.Location = new System.Drawing.Point(209, 299);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(142, 21);
            this.lblNomeUser.TabIndex = 28;
            this.lblNomeUser.Text = "Nome de Usuário";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(210, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 35);
            this.txtEmail.TabIndex = 19;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(210, 115);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(380, 35);
            this.txtLogin.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Orange;
            this.lblEmail.Location = new System.Drawing.Point(206, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // lblUsuarioNome
            // 
            this.lblUsuarioNome.AutoSize = true;
            this.lblUsuarioNome.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioNome.ForeColor = System.Drawing.Color.Orange;
            this.lblUsuarioNome.Location = new System.Drawing.Point(208, 91);
            this.lblUsuarioNome.Name = "lblUsuarioNome";
            this.lblUsuarioNome.Size = new System.Drawing.Size(57, 21);
            this.lblUsuarioNome.TabIndex = 23;
            this.lblUsuarioNome.Text = "Nome";
            // 
            // frmCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(792, 615);
            this.Controls.Add(this.SenhaBox);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.lblConfirmeSenhaCadastro);
            this.Controls.Add(this.btnCadastroUser);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsuarioNome);
            this.Controls.Add(this.panelLogo);
            this.DoubleBuffered = true;
            this.Name = "frmCadastroUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SenhaBox;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblConfirmeSenhaCadastro;
        private System.Windows.Forms.Button btnCadastroUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsuarioNome;
    }
}
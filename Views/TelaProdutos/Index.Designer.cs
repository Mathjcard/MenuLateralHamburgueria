namespace MenuLateralHamburgueria.Views.TelaProdutos
{
    partial class Index
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grbListaProdutos = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panelPreco = new System.Windows.Forms.Panel();
            this.txtPrecoUni = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoUni = new System.Windows.Forms.Label();
            this.panelNome = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            this.grbListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panelTipo.SuspendLayout();
            this.panelPreco.SuspendLayout();
            this.panelNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Orange;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1154, 67);
            this.panelLogo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 55);
            this.label2.TabIndex = 100002;
            this.label2.Text = "PRODUTOS";
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.btnCancelar);
            this.panelConteudo.Controls.Add(this.btnSalvar);
            this.panelConteudo.Controls.Add(this.btnEditar);
            this.panelConteudo.Controls.Add(this.grbListaProdutos);
            this.panelConteudo.Controls.Add(this.btnCadastrar);
            this.panelConteudo.Controls.Add(this.panelTipo);
            this.panelConteudo.Controls.Add(this.panelPreco);
            this.panelConteudo.Controls.Add(this.panelNome);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 67);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(1154, 489);
            this.panelConteudo.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditar.Location = new System.Drawing.Point(388, 94);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 35);
            this.btnEditar.TabIndex = 100050;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grbListaProdutos
            // 
            this.grbListaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbListaProdutos.Controls.Add(this.dgvProdutos);
            this.grbListaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaProdutos.Location = new System.Drawing.Point(12, 139);
            this.grbListaProdutos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.grbListaProdutos.Name = "grbListaProdutos";
            this.grbListaProdutos.Padding = new System.Windows.Forms.Padding(15, 10, 15, 5);
            this.grbListaProdutos.Size = new System.Drawing.Size(1130, 338);
            this.grbListaProdutos.TabIndex = 100049;
            this.grbListaProdutos.TabStop = false;
            this.grbListaProdutos.Text = "Lista Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(15, 29);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1100, 304);
            this.dgvProdutos.TabIndex = 100048;
            this.dgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(568, 94);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 35);
            this.btnCadastrar.TabIndex = 100047;
            this.btnCadastrar.Text = "Cadastrar Produto";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelTipo
            // 
            this.panelTipo.Controls.Add(this.cmbTipo);
            this.panelTipo.Controls.Add(this.lblTipo);
            this.panelTipo.Location = new System.Drawing.Point(470, 6);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Padding = new System.Windows.Forms.Padding(15, 10, 5, 0);
            this.panelTipo.Size = new System.Drawing.Size(271, 74);
            this.panelTipo.TabIndex = 2;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cmbTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Bebida",
            "Lanche",
            "Porção",
            "Combo"});
            this.cmbTipo.Location = new System.Drawing.Point(22, 34);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(0);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(244, 37);
            this.cmbTipo.TabIndex = 26;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Orange;
            this.lblTipo.Location = new System.Drawing.Point(18, 10);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 25;
            this.lblTipo.Text = "Tipo";
            // 
            // panelPreco
            // 
            this.panelPreco.Controls.Add(this.txtPrecoUni);
            this.panelPreco.Controls.Add(this.lblPrecoUni);
            this.panelPreco.Location = new System.Drawing.Point(747, 6);
            this.panelPreco.Name = "panelPreco";
            this.panelPreco.Padding = new System.Windows.Forms.Padding(15, 10, 1, 0);
            this.panelPreco.Size = new System.Drawing.Size(185, 74);
            this.panelPreco.TabIndex = 1;
            // 
            // txtPrecoUni
            // 
            this.txtPrecoUni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoUni.Enabled = false;
            this.txtPrecoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPrecoUni.Location = new System.Drawing.Point(22, 34);
            this.txtPrecoUni.Mask = "00.00";
            this.txtPrecoUni.Name = "txtPrecoUni";
            this.txtPrecoUni.Size = new System.Drawing.Size(159, 35);
            this.txtPrecoUni.TabIndex = 26;
            // 
            // lblPrecoUni
            // 
            this.lblPrecoUni.AutoSize = true;
            this.lblPrecoUni.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUni.ForeColor = System.Drawing.Color.Orange;
            this.lblPrecoUni.Location = new System.Drawing.Point(18, 10);
            this.lblPrecoUni.Name = "lblPrecoUni";
            this.lblPrecoUni.Size = new System.Drawing.Size(109, 20);
            this.lblPrecoUni.TabIndex = 25;
            this.lblPrecoUni.Text = "Preço Unitário";
            // 
            // panelNome
            // 
            this.panelNome.Controls.Add(this.txtNome);
            this.panelNome.Controls.Add(this.lblNome);
            this.panelNome.Location = new System.Drawing.Point(222, 6);
            this.panelNome.Name = "panelNome";
            this.panelNome.Padding = new System.Windows.Forms.Padding(15, 10, 5, 0);
            this.panelNome.Size = new System.Drawing.Size(242, 74);
            this.panelNome.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(22, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 35);
            this.txtNome.TabIndex = 24;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Orange;
            this.lblNome.Location = new System.Drawing.Point(18, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Green;
            this.btnSalvar.Location = new System.Drawing.Point(748, 94);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(175, 35);
            this.btnSalvar.TabIndex = 100051;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(208, 94);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(175, 35);
            this.btnCancelar.TabIndex = 100052;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 556);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelLogo);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelConteudo.ResumeLayout(false);
            this.grbListaProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.panelPreco.ResumeLayout(false);
            this.panelPreco.PerformLayout();
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panelPreco;
        private System.Windows.Forms.Label lblPrecoUni;
        private System.Windows.Forms.MaskedTextBox txtPrecoUni;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbListaProdutos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
namespace MenuLateralHamburgueria
{
    partial class frmProdutos
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.lblMesas = new System.Windows.Forms.Label();
            this.cmbMesas = new System.Windows.Forms.ComboBox();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precounitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lanchoneteDataSet = new MenuLateralHamburgueria.lanchoneteDataSet();
            this.produtosTableAdapter = new MenuLateralHamburgueria.lanchoneteDataSetTableAdapters.produtosTableAdapter();
            this.btnNew_Item = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanchoneteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Orange;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(977, 67);
            this.panelLogo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 55);
            this.label2.TabIndex = 100002;
            this.label2.Text = "PRODUTOS";
            // 
            // imgLancheMilao
            // 
            this.imgLancheMilao.Image = ((System.Drawing.Image)(resources.GetObject("imgLancheMilao.Image")));
            this.imgLancheMilao.Location = new System.Drawing.Point(6, 4);
            this.imgLancheMilao.Name = "imgLancheMilao";
            this.imgLancheMilao.Size = new System.Drawing.Size(87, 79);
            this.imgLancheMilao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLancheMilao.TabIndex = 5;
            this.imgLancheMilao.TabStop = false;
            // 
            // lblLanches
            // 
            this.lblLanches.AutoSize = true;
            this.lblLanches.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanches.Location = new System.Drawing.Point(12, 143);
            this.lblLanches.Name = "lblLanches";
            this.lblLanches.Size = new System.Drawing.Size(118, 25);
            this.lblLanches.TabIndex = 100003;
            this.lblLanches.Text = "LANCHES";
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas.Location = new System.Drawing.Point(12, 343);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(109, 25);
            this.lblBebidas.TabIndex = 100004;
            this.lblBebidas.Text = "BEBIDAS";
            // 
            // pnlLancheMiami
            // 
            this.pnlLancheMiami.Controls.Add(this.pnlControlesLancheMiami);
            this.pnlLancheMiami.Controls.Add(this.lblLancheMiami);
            this.pnlLancheMiami.Controls.Add(this.imgLancheMiami);
            this.pnlLancheMiami.Location = new System.Drawing.Point(7, 7);
            this.pnlLancheMiami.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlLancheMiami.Name = "pnlLancheMiami";
            this.pnlLancheMiami.Size = new System.Drawing.Size(98, 147);
            this.pnlLancheMiami.TabIndex = 100042;
            // 
            // pnlControlesLancheMiami
            // 
            this.pnlControlesLancheMiami.Controls.Add(this.mtbQuantidadeMiami);
            this.pnlControlesLancheMiami.Controls.Add(this.ptbExcMiami);
            this.pnlControlesLancheMiami.Controls.Add(this.ptbAddMiami);
            this.pnlControlesLancheMiami.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesLancheMiami.Name = "pnlControlesLancheMiami";
            this.pnlControlesLancheMiami.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesLancheMiami.TabIndex = 100007;
            // 
            // mtbQuantidadeMiami
            // 
            this.mtbQuantidadeMiami.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeMiami.Mask = "00";
            this.mtbQuantidadeMiami.Name = "mtbQuantidadeMiami";
            this.mtbQuantidadeMiami.ReadOnly = true;
            this.mtbQuantidadeMiami.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeMiami.TabIndex = 100012;
            this.mtbQuantidadeMiami.Text = "0";
            this.mtbQuantidadeMiami.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcMiami
            // 
            this.ptbExcMiami.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcMiami.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcMiami.Image")));
            this.ptbExcMiami.Location = new System.Drawing.Point(11, 8);
            this.ptbExcMiami.Name = "ptbExcMiami";
            this.ptbExcMiami.Size = new System.Drawing.Size(20, 20);
            this.ptbExcMiami.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcMiami.TabIndex = 100011;
            this.ptbExcMiami.TabStop = false;
            this.ptbExcMiami.Click += new System.EventHandler(this.ptbExcMiami_Click);
            // 
            // ptbAddMiami
            // 
            this.ptbAddMiami.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddMiami.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddMiami.Image")));
            this.ptbAddMiami.Location = new System.Drawing.Point(68, 8);
            this.ptbAddMiami.Name = "ptbAddMiami";
            this.ptbAddMiami.Size = new System.Drawing.Size(20, 20);
            this.ptbAddMiami.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddMiami.TabIndex = 100010;
            this.ptbAddMiami.TabStop = false;
            this.ptbAddMiami.Click += new System.EventHandler(this.ptbAddMiami_Click);
            // 
            // lblLancheMiami
            // 
            this.lblLancheMiami.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancheMiami.Location = new System.Drawing.Point(15, 89);
            this.lblLancheMiami.Name = "lblLancheMiami";
            this.lblLancheMiami.Size = new System.Drawing.Size(68, 21);
            this.lblLancheMiami.TabIndex = 100006;
            this.lblLancheMiami.Text = "MIAMI";
            this.lblLancheMiami.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLancheMiami
            // 
            this.imgLancheMiami.Image = ((System.Drawing.Image)(resources.GetObject("imgLancheMiami.Image")));
            this.imgLancheMiami.Location = new System.Drawing.Point(6, 5);
            this.imgLancheMiami.Margin = new System.Windows.Forms.Padding(5);
            this.imgLancheMiami.Name = "imgLancheMiami";
            this.imgLancheMiami.Size = new System.Drawing.Size(87, 79);
            this.imgLancheMiami.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLancheMiami.TabIndex = 1;
            this.imgLancheMiami.TabStop = false;
            // 
            // pnlLancheNovaYork
            // 
            this.pnlLancheNovaYork.Controls.Add(this.imgLancheNovaYork);
            this.pnlLancheNovaYork.Controls.Add(this.pnlControlesLancheNY);
            this.pnlLancheNovaYork.Controls.Add(this.lblLancheNovaYork);
            this.pnlLancheNovaYork.Location = new System.Drawing.Point(115, 7);
            this.pnlLancheNovaYork.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlLancheNovaYork.Name = "pnlLancheNovaYork";
            this.pnlLancheNovaYork.Size = new System.Drawing.Size(98, 147);
            this.pnlLancheNovaYork.TabIndex = 100043;
            // 
            // imgLancheNovaYork
            // 
            this.imgLancheNovaYork.Image = ((System.Drawing.Image)(resources.GetObject("imgLancheNovaYork.Image")));
            this.imgLancheNovaYork.Location = new System.Drawing.Point(6, 5);
            this.imgLancheNovaYork.Margin = new System.Windows.Forms.Padding(5);
            this.imgLancheNovaYork.Name = "imgLancheNovaYork";
            this.imgLancheNovaYork.Size = new System.Drawing.Size(87, 79);
            this.imgLancheNovaYork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLancheNovaYork.TabIndex = 100008;
            this.imgLancheNovaYork.TabStop = false;
            // 
            // pnlControlesLancheNY
            // 
            this.pnlControlesLancheNY.Controls.Add(this.mtbQuantidadeNovaYork);
            this.pnlControlesLancheNY.Controls.Add(this.ptbExcNovaYork);
            this.pnlControlesLancheNY.Controls.Add(this.ptbAddNovaYork);
            this.pnlControlesLancheNY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesLancheNY.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesLancheNY.Name = "pnlControlesLancheNY";
            this.pnlControlesLancheNY.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesLancheNY.TabIndex = 100007;
            // 
            // mtbQuantidadeNovaYork
            // 
            this.mtbQuantidadeNovaYork.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeNovaYork.Mask = "000";
            this.mtbQuantidadeNovaYork.Name = "mtbQuantidadeNovaYork";
            this.mtbQuantidadeNovaYork.ReadOnly = true;
            this.mtbQuantidadeNovaYork.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeNovaYork.TabIndex = 100012;
            this.mtbQuantidadeNovaYork.Text = "0";
            this.mtbQuantidadeNovaYork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcNovaYork
            // 
            this.ptbExcNovaYork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcNovaYork.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcNovaYork.Image")));
            this.ptbExcNovaYork.Location = new System.Drawing.Point(12, 8);
            this.ptbExcNovaYork.Name = "ptbExcNovaYork";
            this.ptbExcNovaYork.Size = new System.Drawing.Size(20, 20);
            this.ptbExcNovaYork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcNovaYork.TabIndex = 100011;
            this.ptbExcNovaYork.TabStop = false;
            this.ptbExcNovaYork.Click += new System.EventHandler(this.ptbExcNovaYork_Click);
            // 
            // ptbAddNovaYork
            // 
            this.ptbAddNovaYork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddNovaYork.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddNovaYork.Image")));
            this.ptbAddNovaYork.Location = new System.Drawing.Point(67, 8);
            this.ptbAddNovaYork.Name = "ptbAddNovaYork";
            this.ptbAddNovaYork.Size = new System.Drawing.Size(20, 20);
            this.ptbAddNovaYork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddNovaYork.TabIndex = 100010;
            this.ptbAddNovaYork.TabStop = false;
            this.ptbAddNovaYork.Click += new System.EventHandler(this.ptbAddNovaYork_Click);
            // 
            // lblLancheNovaYork
            // 
            this.lblLancheNovaYork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancheNovaYork.Location = new System.Drawing.Point(2, 89);
            this.lblLancheNovaYork.Name = "lblLancheNovaYork";
            this.lblLancheNovaYork.Size = new System.Drawing.Size(95, 21);
            this.lblLancheNovaYork.TabIndex = 100006;
            this.lblLancheNovaYork.Text = "NOVA YORK";
            this.lblLancheNovaYork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLancheDetroit
            // 
            this.pnlLancheDetroit.Controls.Add(this.imgLancheDetroit);
            this.pnlLancheDetroit.Controls.Add(this.pnlControlesLancheDetroit);
            this.pnlLancheDetroit.Controls.Add(this.lblLancheDetroit);
            this.pnlLancheDetroit.Location = new System.Drawing.Point(223, 7);
            this.pnlLancheDetroit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlLancheDetroit.Name = "pnlLancheDetroit";
            this.pnlLancheDetroit.Size = new System.Drawing.Size(98, 147);
            this.pnlLancheDetroit.TabIndex = 100044;
            // 
            // imgLancheDetroit
            // 
            this.imgLancheDetroit.Image = ((System.Drawing.Image)(resources.GetObject("imgLancheDetroit.Image")));
            this.imgLancheDetroit.Location = new System.Drawing.Point(6, 5);
            this.imgLancheDetroit.Margin = new System.Windows.Forms.Padding(5);
            this.imgLancheDetroit.Name = "imgLancheDetroit";
            this.imgLancheDetroit.Size = new System.Drawing.Size(87, 79);
            this.imgLancheDetroit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLancheDetroit.TabIndex = 100013;
            this.imgLancheDetroit.TabStop = false;
            // 
            // pnlControlesLancheDetroit
            // 
            this.pnlControlesLancheDetroit.Controls.Add(this.mtbQuantidadeDetroit);
            this.pnlControlesLancheDetroit.Controls.Add(this.ptbExcDetroit);
            this.pnlControlesLancheDetroit.Controls.Add(this.ptbAddDetroit);
            this.pnlControlesLancheDetroit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesLancheDetroit.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesLancheDetroit.Name = "pnlControlesLancheDetroit";
            this.pnlControlesLancheDetroit.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesLancheDetroit.TabIndex = 100007;
            // 
            // mtbQuantidadeDetroit
            // 
            this.mtbQuantidadeDetroit.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeDetroit.Mask = "000";
            this.mtbQuantidadeDetroit.Name = "mtbQuantidadeDetroit";
            this.mtbQuantidadeDetroit.ReadOnly = true;
            this.mtbQuantidadeDetroit.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeDetroit.TabIndex = 100012;
            this.mtbQuantidadeDetroit.Text = "0";
            this.mtbQuantidadeDetroit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcDetroit
            // 
            this.ptbExcDetroit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcDetroit.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcDetroit.Image")));
            this.ptbExcDetroit.Location = new System.Drawing.Point(12, 8);
            this.ptbExcDetroit.Name = "ptbExcDetroit";
            this.ptbExcDetroit.Size = new System.Drawing.Size(20, 20);
            this.ptbExcDetroit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcDetroit.TabIndex = 100011;
            this.ptbExcDetroit.TabStop = false;
            this.ptbExcDetroit.Click += new System.EventHandler(this.ptbExcDetroit_Click);
            // 
            // ptbAddDetroit
            // 
            this.ptbAddDetroit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddDetroit.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddDetroit.Image")));
            this.ptbAddDetroit.Location = new System.Drawing.Point(67, 8);
            this.ptbAddDetroit.Name = "ptbAddDetroit";
            this.ptbAddDetroit.Size = new System.Drawing.Size(20, 20);
            this.ptbAddDetroit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddDetroit.TabIndex = 100010;
            this.ptbAddDetroit.TabStop = false;
            this.ptbAddDetroit.Click += new System.EventHandler(this.ptbAddDetroit_Click);
            // 
            // lblLancheDetroit
            // 
            this.lblLancheDetroit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancheDetroit.Location = new System.Drawing.Point(11, 89);
            this.lblLancheDetroit.Name = "lblLancheDetroit";
            this.lblLancheDetroit.Size = new System.Drawing.Size(77, 21);
            this.lblLancheDetroit.TabIndex = 100006;
            this.lblLancheDetroit.Text = "DETROIT";
            this.lblLancheDetroit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLancheAmazonas
            // 
            this.pnlLancheAmazonas.Controls.Add(this.imgLancheAmazonas);
            this.pnlLancheAmazonas.Controls.Add(this.pnlControlesLancheAmazonas);
            this.pnlLancheAmazonas.Controls.Add(this.lblLancheAmazonas);
            this.pnlLancheAmazonas.Location = new System.Drawing.Point(331, 7);
            this.pnlLancheAmazonas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlLancheAmazonas.Name = "pnlLancheAmazonas";
            this.pnlLancheAmazonas.Size = new System.Drawing.Size(98, 147);
            this.pnlLancheAmazonas.TabIndex = 100045;
            // 
            // imgLancheAmazonas
            // 
            this.imgLancheAmazonas.Image = ((System.Drawing.Image)(resources.GetObject("imgLancheAmazonas.Image")));
            this.imgLancheAmazonas.Location = new System.Drawing.Point(6, 5);
            this.imgLancheAmazonas.Margin = new System.Windows.Forms.Padding(5);
            this.imgLancheAmazonas.Name = "imgLancheAmazonas";
            this.imgLancheAmazonas.Size = new System.Drawing.Size(87, 79);
            this.imgLancheAmazonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLancheAmazonas.TabIndex = 100008;
            this.imgLancheAmazonas.TabStop = false;
            // 
            // pnlControlesLancheAmazonas
            // 
            this.pnlControlesLancheAmazonas.Controls.Add(this.mtbQuantidadeAmazonas);
            this.pnlControlesLancheAmazonas.Controls.Add(this.ptbExcAmazonas);
            this.pnlControlesLancheAmazonas.Controls.Add(this.ptbAddAmazonas);
            this.pnlControlesLancheAmazonas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesLancheAmazonas.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesLancheAmazonas.Name = "pnlControlesLancheAmazonas";
            this.pnlControlesLancheAmazonas.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesLancheAmazonas.TabIndex = 100007;
            // 
            // mtbQuantidadeAmazonas
            // 
            this.mtbQuantidadeAmazonas.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeAmazonas.Mask = "000";
            this.mtbQuantidadeAmazonas.Name = "mtbQuantidadeAmazonas";
            this.mtbQuantidadeAmazonas.ReadOnly = true;
            this.mtbQuantidadeAmazonas.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeAmazonas.TabIndex = 100012;
            this.mtbQuantidadeAmazonas.Text = "0";
            this.mtbQuantidadeAmazonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcAmazonas
            // 
            this.ptbExcAmazonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcAmazonas.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcAmazonas.Image")));
            this.ptbExcAmazonas.Location = new System.Drawing.Point(12, 8);
            this.ptbExcAmazonas.Name = "ptbExcAmazonas";
            this.ptbExcAmazonas.Size = new System.Drawing.Size(20, 20);
            this.ptbExcAmazonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcAmazonas.TabIndex = 100011;
            this.ptbExcAmazonas.TabStop = false;
            this.ptbExcAmazonas.Click += new System.EventHandler(this.ptbExcAmazonas_Click);
            // 
            // ptbAddAmazonas
            // 
            this.ptbAddAmazonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddAmazonas.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddAmazonas.Image")));
            this.ptbAddAmazonas.Location = new System.Drawing.Point(67, 8);
            this.ptbAddAmazonas.Name = "ptbAddAmazonas";
            this.ptbAddAmazonas.Size = new System.Drawing.Size(20, 20);
            this.ptbAddAmazonas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddAmazonas.TabIndex = 100010;
            this.ptbAddAmazonas.TabStop = false;
            this.ptbAddAmazonas.Click += new System.EventHandler(this.ptbAddAmazonas_Click);
            // 
            // lblLancheAmazonas
            // 
            this.lblLancheAmazonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancheAmazonas.Location = new System.Drawing.Point(3, 89);
            this.lblLancheAmazonas.Name = "lblLancheAmazonas";
            this.lblLancheAmazonas.Size = new System.Drawing.Size(92, 21);
            this.lblLancheAmazonas.TabIndex = 100006;
            this.lblLancheAmazonas.Text = "AMAZONAS";
            this.lblLancheAmazonas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLanches
            // 
            this.pnlLanches.BackColor = System.Drawing.Color.Orange;
            this.pnlLanches.Controls.Add(this.pnlLancheMilao);
            this.pnlLanches.Controls.Add(this.pnlLanchePaulista);
            this.pnlLanches.Controls.Add(this.pnlLancheAmazonas);
            this.pnlLanches.Controls.Add(this.pnlLancheDetroit);
            this.pnlLanches.Controls.Add(this.pnlLancheNovaYork);
            this.pnlLanches.Controls.Add(this.pnlLancheMiami);
            this.pnlLanches.Location = new System.Drawing.Point(17, 171);
            this.pnlLanches.Name = "pnlLanches";
            this.pnlLanches.Size = new System.Drawing.Size(653, 160);
            this.pnlLanches.TabIndex = 100043;
            // 
            // pnlLancheMilao
            // 
            this.pnlLancheMilao.Controls.Add(this.pnlControlesLancheMilao);
            this.pnlLancheMilao.Controls.Add(this.imgLancheMilao);
            this.pnlLancheMilao.Controls.Add(this.lblLancheMilao);
            this.pnlLancheMilao.Location = new System.Drawing.Point(547, 8);
            this.pnlLancheMilao.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlLancheMilao.Name = "pnlLancheMilao";
            this.pnlLancheMilao.Size = new System.Drawing.Size(98, 147);
            this.pnlLancheMilao.TabIndex = 100047;
            // 
            // pnlControlesLancheMilao
            // 
            this.pnlControlesLancheMilao.Controls.Add(this.mtbQuantidadeMilao);
            this.pnlControlesLancheMilao.Controls.Add(this.ptbExcMilao);
            this.pnlControlesLancheMilao.Controls.Add(this.ptbAddMilao);
            this.pnlControlesLancheMilao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesLancheMilao.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesLancheMilao.Name = "pnlControlesLancheMilao";
            this.pnlControlesLancheMilao.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesLancheMilao.TabIndex = 100007;
            // 
            // mtbQuantidadeMilao
            // 
            this.mtbQuantidadeMilao.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeMilao.Mask = "000";
            this.mtbQuantidadeMilao.Name = "mtbQuantidadeMilao";
            this.mtbQuantidadeMilao.ReadOnly = true;
            this.mtbQuantidadeMilao.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeMilao.TabIndex = 100012;
            this.mtbQuantidadeMilao.Text = "0";
            this.mtbQuantidadeMilao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcMilao
            // 
            this.ptbExcMilao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcMilao.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcMilao.Image")));
            this.ptbExcMilao.Location = new System.Drawing.Point(12, 8);
            this.ptbExcMilao.Name = "ptbExcMilao";
            this.ptbExcMilao.Size = new System.Drawing.Size(20, 20);
            this.ptbExcMilao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcMilao.TabIndex = 100011;
            this.ptbExcMilao.TabStop = false;
            this.ptbExcMilao.Click += new System.EventHandler(this.ptbExcMilao_Click);
            // 
            // ptbAddMilao
            // 
            this.ptbAddMilao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddMilao.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddMilao.Image")));
            this.ptbAddMilao.Location = new System.Drawing.Point(67, 8);
            this.ptbAddMilao.Name = "ptbAddMilao";
            this.ptbAddMilao.Size = new System.Drawing.Size(20, 20);
            this.ptbAddMilao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddMilao.TabIndex = 100010;
            this.ptbAddMilao.TabStop = false;
            this.ptbAddMilao.Click += new System.EventHandler(this.ptbAddMilao_Click);
            // 
            // lblLancheMilao
            // 
            this.lblLancheMilao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancheMilao.Location = new System.Drawing.Point(3, 89);
            this.lblLancheMilao.Name = "lblLancheMilao";
            this.lblLancheMilao.Size = new System.Drawing.Size(92, 21);
            this.lblLancheMilao.TabIndex = 100006;
            this.lblLancheMilao.Text = "MILÃO";
            this.lblLancheMilao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLanchePaulista
            // 
            this.pnlLanchePaulista.Controls.Add(this.imgLanchePaulista);
            this.pnlLanchePaulista.Controls.Add(this.pnlControlesLanchePaulista);
            this.pnlLanchePaulista.Controls.Add(this.lblLanchePaulista);
            this.pnlLanchePaulista.Location = new System.Drawing.Point(439, 7);
            this.pnlLanchePaulista.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlLanchePaulista.Name = "pnlLanchePaulista";
            this.pnlLanchePaulista.Size = new System.Drawing.Size(98, 147);
            this.pnlLanchePaulista.TabIndex = 100046;
            // 
            // imgLanchePaulista
            // 
            this.imgLanchePaulista.Image = ((System.Drawing.Image)(resources.GetObject("imgLanchePaulista.Image")));
            this.imgLanchePaulista.Location = new System.Drawing.Point(6, 5);
            this.imgLanchePaulista.Name = "imgLanchePaulista";
            this.imgLanchePaulista.Size = new System.Drawing.Size(87, 79);
            this.imgLanchePaulista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLanchePaulista.TabIndex = 100013;
            this.imgLanchePaulista.TabStop = false;
            // 
            // pnlControlesLanchePaulista
            // 
            this.pnlControlesLanchePaulista.Controls.Add(this.mtbQuantidadePaulista);
            this.pnlControlesLanchePaulista.Controls.Add(this.ptbExcPaulista);
            this.pnlControlesLanchePaulista.Controls.Add(this.ptbAddPaulista);
            this.pnlControlesLanchePaulista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesLanchePaulista.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesLanchePaulista.Name = "pnlControlesLanchePaulista";
            this.pnlControlesLanchePaulista.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesLanchePaulista.TabIndex = 100007;
            // 
            // mtbQuantidadePaulista
            // 
            this.mtbQuantidadePaulista.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadePaulista.Mask = "000";
            this.mtbQuantidadePaulista.Name = "mtbQuantidadePaulista";
            this.mtbQuantidadePaulista.ReadOnly = true;
            this.mtbQuantidadePaulista.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadePaulista.TabIndex = 100012;
            this.mtbQuantidadePaulista.Text = "0";
            this.mtbQuantidadePaulista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcPaulista
            // 
            this.ptbExcPaulista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcPaulista.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcPaulista.Image")));
            this.ptbExcPaulista.Location = new System.Drawing.Point(12, 8);
            this.ptbExcPaulista.Name = "ptbExcPaulista";
            this.ptbExcPaulista.Size = new System.Drawing.Size(20, 20);
            this.ptbExcPaulista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcPaulista.TabIndex = 100011;
            this.ptbExcPaulista.TabStop = false;
            this.ptbExcPaulista.Click += new System.EventHandler(this.ptbExcPaulista_Click);
            // 
            // ptbAddPaulista
            // 
            this.ptbAddPaulista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddPaulista.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddPaulista.Image")));
            this.ptbAddPaulista.Location = new System.Drawing.Point(67, 8);
            this.ptbAddPaulista.Name = "ptbAddPaulista";
            this.ptbAddPaulista.Size = new System.Drawing.Size(20, 20);
            this.ptbAddPaulista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddPaulista.TabIndex = 100010;
            this.ptbAddPaulista.TabStop = false;
            this.ptbAddPaulista.Click += new System.EventHandler(this.ptbAddPaulista_Click);
            // 
            // lblLanchePaulista
            // 
            this.lblLanchePaulista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanchePaulista.Location = new System.Drawing.Point(3, 89);
            this.lblLanchePaulista.Name = "lblLanchePaulista";
            this.lblLanchePaulista.Size = new System.Drawing.Size(92, 21);
            this.lblLanchePaulista.TabIndex = 100006;
            this.lblLanchePaulista.Text = "PAULISTA";
            this.lblLanchePaulista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBebidas
            // 
            this.pnlBebidas.BackColor = System.Drawing.Color.Orange;
            this.pnlBebidas.Controls.Add(this.pnlBebidaSuco);
            this.pnlBebidas.Controls.Add(this.pnlBebidaGuarana);
            this.pnlBebidas.Controls.Add(this.pnlBebidaPepsi);
            this.pnlBebidas.Controls.Add(this.pnlBebidaCoca);
            this.pnlBebidas.Controls.Add(this.pnlBebidaFanta);
            this.pnlBebidas.Controls.Add(this.pnlBebidaSprite);
            this.pnlBebidas.Location = new System.Drawing.Point(17, 371);
            this.pnlBebidas.Name = "pnlBebidas";
            this.pnlBebidas.Size = new System.Drawing.Size(653, 160);
            this.pnlBebidas.TabIndex = 100045;
            // 
            // pnlBebidaSuco
            // 
            this.pnlBebidaSuco.Controls.Add(this.imgBebidaSuco);
            this.pnlBebidaSuco.Controls.Add(this.pnlControlesSuco);
            this.pnlBebidaSuco.Controls.Add(this.lblBebidaSuco);
            this.pnlBebidaSuco.Location = new System.Drawing.Point(547, 8);
            this.pnlBebidaSuco.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlBebidaSuco.Name = "pnlBebidaSuco";
            this.pnlBebidaSuco.Size = new System.Drawing.Size(98, 147);
            this.pnlBebidaSuco.TabIndex = 100047;
            // 
            // imgBebidaSuco
            // 
            this.imgBebidaSuco.Image = ((System.Drawing.Image)(resources.GetObject("imgBebidaSuco.Image")));
            this.imgBebidaSuco.Location = new System.Drawing.Point(6, 4);
            this.imgBebidaSuco.Margin = new System.Windows.Forms.Padding(5);
            this.imgBebidaSuco.Name = "imgBebidaSuco";
            this.imgBebidaSuco.Size = new System.Drawing.Size(87, 79);
            this.imgBebidaSuco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBebidaSuco.TabIndex = 100013;
            this.imgBebidaSuco.TabStop = false;
            // 
            // pnlControlesSuco
            // 
            this.pnlControlesSuco.Controls.Add(this.mtbQuantidadeSuco);
            this.pnlControlesSuco.Controls.Add(this.ptbExcSuco);
            this.pnlControlesSuco.Controls.Add(this.ptbAddSuco);
            this.pnlControlesSuco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesSuco.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesSuco.Name = "pnlControlesSuco";
            this.pnlControlesSuco.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesSuco.TabIndex = 100007;
            // 
            // mtbQuantidadeSuco
            // 
            this.mtbQuantidadeSuco.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeSuco.Mask = "000";
            this.mtbQuantidadeSuco.Name = "mtbQuantidadeSuco";
            this.mtbQuantidadeSuco.ReadOnly = true;
            this.mtbQuantidadeSuco.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeSuco.TabIndex = 100012;
            this.mtbQuantidadeSuco.Text = "0";
            this.mtbQuantidadeSuco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcSuco
            // 
            this.ptbExcSuco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcSuco.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcSuco.Image")));
            this.ptbExcSuco.Location = new System.Drawing.Point(12, 8);
            this.ptbExcSuco.Name = "ptbExcSuco";
            this.ptbExcSuco.Size = new System.Drawing.Size(20, 20);
            this.ptbExcSuco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcSuco.TabIndex = 100011;
            this.ptbExcSuco.TabStop = false;
            this.ptbExcSuco.Click += new System.EventHandler(this.ptbExcSuco_Click);
            // 
            // ptbAddSuco
            // 
            this.ptbAddSuco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddSuco.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddSuco.Image")));
            this.ptbAddSuco.Location = new System.Drawing.Point(67, 8);
            this.ptbAddSuco.Name = "ptbAddSuco";
            this.ptbAddSuco.Size = new System.Drawing.Size(20, 20);
            this.ptbAddSuco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddSuco.TabIndex = 100010;
            this.ptbAddSuco.TabStop = false;
            this.ptbAddSuco.Click += new System.EventHandler(this.ptbAddSuco_Click);
            // 
            // lblBebidaSuco
            // 
            this.lblBebidaSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaSuco.Location = new System.Drawing.Point(3, 89);
            this.lblBebidaSuco.Name = "lblBebidaSuco";
            this.lblBebidaSuco.Size = new System.Drawing.Size(92, 21);
            this.lblBebidaSuco.TabIndex = 100006;
            this.lblBebidaSuco.Text = "SUCO";
            this.lblBebidaSuco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBebidaGuarana
            // 
            this.pnlBebidaGuarana.Controls.Add(this.imgBebidaGuarana);
            this.pnlBebidaGuarana.Controls.Add(this.pnlControlesGuarana);
            this.pnlBebidaGuarana.Controls.Add(this.lblBebidaGuarana);
            this.pnlBebidaGuarana.Location = new System.Drawing.Point(439, 7);
            this.pnlBebidaGuarana.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlBebidaGuarana.Name = "pnlBebidaGuarana";
            this.pnlBebidaGuarana.Size = new System.Drawing.Size(98, 147);
            this.pnlBebidaGuarana.TabIndex = 100046;
            // 
            // imgBebidaGuarana
            // 
            this.imgBebidaGuarana.Image = ((System.Drawing.Image)(resources.GetObject("imgBebidaGuarana.Image")));
            this.imgBebidaGuarana.Location = new System.Drawing.Point(6, 5);
            this.imgBebidaGuarana.Margin = new System.Windows.Forms.Padding(5);
            this.imgBebidaGuarana.Name = "imgBebidaGuarana";
            this.imgBebidaGuarana.Size = new System.Drawing.Size(87, 79);
            this.imgBebidaGuarana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBebidaGuarana.TabIndex = 100013;
            this.imgBebidaGuarana.TabStop = false;
            // 
            // pnlControlesGuarana
            // 
            this.pnlControlesGuarana.Controls.Add(this.mtbQuantidadeGuarana);
            this.pnlControlesGuarana.Controls.Add(this.ptbExcGuarana);
            this.pnlControlesGuarana.Controls.Add(this.ptbAddGuarana);
            this.pnlControlesGuarana.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesGuarana.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesGuarana.Name = "pnlControlesGuarana";
            this.pnlControlesGuarana.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesGuarana.TabIndex = 100007;
            // 
            // mtbQuantidadeGuarana
            // 
            this.mtbQuantidadeGuarana.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeGuarana.Mask = "000";
            this.mtbQuantidadeGuarana.Name = "mtbQuantidadeGuarana";
            this.mtbQuantidadeGuarana.ReadOnly = true;
            this.mtbQuantidadeGuarana.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeGuarana.TabIndex = 100012;
            this.mtbQuantidadeGuarana.Text = "0";
            this.mtbQuantidadeGuarana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcGuarana
            // 
            this.ptbExcGuarana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcGuarana.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcGuarana.Image")));
            this.ptbExcGuarana.Location = new System.Drawing.Point(12, 8);
            this.ptbExcGuarana.Name = "ptbExcGuarana";
            this.ptbExcGuarana.Size = new System.Drawing.Size(20, 20);
            this.ptbExcGuarana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcGuarana.TabIndex = 100011;
            this.ptbExcGuarana.TabStop = false;
            this.ptbExcGuarana.Click += new System.EventHandler(this.ptbExcGuarana_Click);
            // 
            // ptbAddGuarana
            // 
            this.ptbAddGuarana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddGuarana.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddGuarana.Image")));
            this.ptbAddGuarana.Location = new System.Drawing.Point(67, 8);
            this.ptbAddGuarana.Name = "ptbAddGuarana";
            this.ptbAddGuarana.Size = new System.Drawing.Size(20, 20);
            this.ptbAddGuarana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddGuarana.TabIndex = 100010;
            this.ptbAddGuarana.TabStop = false;
            this.ptbAddGuarana.Click += new System.EventHandler(this.ptbAddGuarana_Click);
            // 
            // lblBebidaGuarana
            // 
            this.lblBebidaGuarana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaGuarana.Location = new System.Drawing.Point(3, 89);
            this.lblBebidaGuarana.Name = "lblBebidaGuarana";
            this.lblBebidaGuarana.Size = new System.Drawing.Size(92, 21);
            this.lblBebidaGuarana.TabIndex = 100006;
            this.lblBebidaGuarana.Text = "GUARANÁ";
            this.lblBebidaGuarana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBebidaPepsi
            // 
            this.pnlBebidaPepsi.Controls.Add(this.imgBebidaPepsi);
            this.pnlBebidaPepsi.Controls.Add(this.pnlControlesPepsi);
            this.pnlBebidaPepsi.Controls.Add(this.lblBebidaPepsi);
            this.pnlBebidaPepsi.Location = new System.Drawing.Point(331, 7);
            this.pnlBebidaPepsi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlBebidaPepsi.Name = "pnlBebidaPepsi";
            this.pnlBebidaPepsi.Size = new System.Drawing.Size(98, 147);
            this.pnlBebidaPepsi.TabIndex = 100045;
            // 
            // imgBebidaPepsi
            // 
            this.imgBebidaPepsi.Image = ((System.Drawing.Image)(resources.GetObject("imgBebidaPepsi.Image")));
            this.imgBebidaPepsi.Location = new System.Drawing.Point(6, 5);
            this.imgBebidaPepsi.Margin = new System.Windows.Forms.Padding(5);
            this.imgBebidaPepsi.Name = "imgBebidaPepsi";
            this.imgBebidaPepsi.Size = new System.Drawing.Size(87, 79);
            this.imgBebidaPepsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBebidaPepsi.TabIndex = 100013;
            this.imgBebidaPepsi.TabStop = false;
            // 
            // pnlControlesPepsi
            // 
            this.pnlControlesPepsi.Controls.Add(this.mtbQuantidadePepsi);
            this.pnlControlesPepsi.Controls.Add(this.ptbExcPepsi);
            this.pnlControlesPepsi.Controls.Add(this.ptbAddPepsi);
            this.pnlControlesPepsi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesPepsi.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesPepsi.Name = "pnlControlesPepsi";
            this.pnlControlesPepsi.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesPepsi.TabIndex = 100007;
            // 
            // mtbQuantidadePepsi
            // 
            this.mtbQuantidadePepsi.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadePepsi.Mask = "000";
            this.mtbQuantidadePepsi.Name = "mtbQuantidadePepsi";
            this.mtbQuantidadePepsi.ReadOnly = true;
            this.mtbQuantidadePepsi.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadePepsi.TabIndex = 100012;
            this.mtbQuantidadePepsi.Text = "0";
            this.mtbQuantidadePepsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcPepsi
            // 
            this.ptbExcPepsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcPepsi.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcPepsi.Image")));
            this.ptbExcPepsi.Location = new System.Drawing.Point(12, 8);
            this.ptbExcPepsi.Name = "ptbExcPepsi";
            this.ptbExcPepsi.Size = new System.Drawing.Size(20, 20);
            this.ptbExcPepsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcPepsi.TabIndex = 100011;
            this.ptbExcPepsi.TabStop = false;
            this.ptbExcPepsi.Click += new System.EventHandler(this.ptbExcPepsi_Click);
            // 
            // ptbAddPepsi
            // 
            this.ptbAddPepsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddPepsi.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddPepsi.Image")));
            this.ptbAddPepsi.Location = new System.Drawing.Point(67, 8);
            this.ptbAddPepsi.Name = "ptbAddPepsi";
            this.ptbAddPepsi.Size = new System.Drawing.Size(20, 20);
            this.ptbAddPepsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddPepsi.TabIndex = 100010;
            this.ptbAddPepsi.TabStop = false;
            this.ptbAddPepsi.Click += new System.EventHandler(this.ptbAddPepsi_Click);
            // 
            // lblBebidaPepsi
            // 
            this.lblBebidaPepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaPepsi.Location = new System.Drawing.Point(3, 89);
            this.lblBebidaPepsi.Name = "lblBebidaPepsi";
            this.lblBebidaPepsi.Size = new System.Drawing.Size(92, 21);
            this.lblBebidaPepsi.TabIndex = 100006;
            this.lblBebidaPepsi.Text = "PEPSI";
            this.lblBebidaPepsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBebidaCoca
            // 
            this.pnlBebidaCoca.Controls.Add(this.imgBebidaCoca);
            this.pnlBebidaCoca.Controls.Add(this.pnlControlesCoca);
            this.pnlBebidaCoca.Controls.Add(this.lblBebidaCoca);
            this.pnlBebidaCoca.Location = new System.Drawing.Point(223, 7);
            this.pnlBebidaCoca.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlBebidaCoca.Name = "pnlBebidaCoca";
            this.pnlBebidaCoca.Size = new System.Drawing.Size(98, 147);
            this.pnlBebidaCoca.TabIndex = 100044;
            // 
            // imgBebidaCoca
            // 
            this.imgBebidaCoca.Image = ((System.Drawing.Image)(resources.GetObject("imgBebidaCoca.Image")));
            this.imgBebidaCoca.Location = new System.Drawing.Point(6, 5);
            this.imgBebidaCoca.Margin = new System.Windows.Forms.Padding(5);
            this.imgBebidaCoca.Name = "imgBebidaCoca";
            this.imgBebidaCoca.Size = new System.Drawing.Size(87, 79);
            this.imgBebidaCoca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBebidaCoca.TabIndex = 100008;
            this.imgBebidaCoca.TabStop = false;
            // 
            // pnlControlesCoca
            // 
            this.pnlControlesCoca.Controls.Add(this.mtbQuantidadeCoca);
            this.pnlControlesCoca.Controls.Add(this.ptbExcCoca);
            this.pnlControlesCoca.Controls.Add(this.ptbAddCoca);
            this.pnlControlesCoca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesCoca.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesCoca.Name = "pnlControlesCoca";
            this.pnlControlesCoca.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesCoca.TabIndex = 100007;
            // 
            // mtbQuantidadeCoca
            // 
            this.mtbQuantidadeCoca.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeCoca.Mask = "000";
            this.mtbQuantidadeCoca.Name = "mtbQuantidadeCoca";
            this.mtbQuantidadeCoca.ReadOnly = true;
            this.mtbQuantidadeCoca.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeCoca.TabIndex = 100012;
            this.mtbQuantidadeCoca.Text = "0";
            this.mtbQuantidadeCoca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcCoca
            // 
            this.ptbExcCoca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcCoca.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcCoca.Image")));
            this.ptbExcCoca.Location = new System.Drawing.Point(12, 8);
            this.ptbExcCoca.Name = "ptbExcCoca";
            this.ptbExcCoca.Size = new System.Drawing.Size(20, 20);
            this.ptbExcCoca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcCoca.TabIndex = 100011;
            this.ptbExcCoca.TabStop = false;
            this.ptbExcCoca.Click += new System.EventHandler(this.ptbExcCoca_Click);
            // 
            // ptbAddCoca
            // 
            this.ptbAddCoca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddCoca.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddCoca.Image")));
            this.ptbAddCoca.Location = new System.Drawing.Point(67, 8);
            this.ptbAddCoca.Name = "ptbAddCoca";
            this.ptbAddCoca.Size = new System.Drawing.Size(20, 20);
            this.ptbAddCoca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddCoca.TabIndex = 100010;
            this.ptbAddCoca.TabStop = false;
            this.ptbAddCoca.Click += new System.EventHandler(this.ptbAddCoca_Click);
            // 
            // lblBebidaCoca
            // 
            this.lblBebidaCoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaCoca.Location = new System.Drawing.Point(1, 89);
            this.lblBebidaCoca.Name = "lblBebidaCoca";
            this.lblBebidaCoca.Size = new System.Drawing.Size(97, 21);
            this.lblBebidaCoca.TabIndex = 100006;
            this.lblBebidaCoca.Text = "COCA-COLA";
            this.lblBebidaCoca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBebidaFanta
            // 
            this.pnlBebidaFanta.Controls.Add(this.imgBebidaFanta);
            this.pnlBebidaFanta.Controls.Add(this.pnlControlesFanta);
            this.pnlBebidaFanta.Controls.Add(this.lblBebidaFanta);
            this.pnlBebidaFanta.Location = new System.Drawing.Point(115, 7);
            this.pnlBebidaFanta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlBebidaFanta.Name = "pnlBebidaFanta";
            this.pnlBebidaFanta.Size = new System.Drawing.Size(98, 147);
            this.pnlBebidaFanta.TabIndex = 100043;
            // 
            // imgBebidaFanta
            // 
            this.imgBebidaFanta.Image = ((System.Drawing.Image)(resources.GetObject("imgBebidaFanta.Image")));
            this.imgBebidaFanta.Location = new System.Drawing.Point(6, 5);
            this.imgBebidaFanta.Margin = new System.Windows.Forms.Padding(5);
            this.imgBebidaFanta.Name = "imgBebidaFanta";
            this.imgBebidaFanta.Size = new System.Drawing.Size(87, 79);
            this.imgBebidaFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBebidaFanta.TabIndex = 100009;
            this.imgBebidaFanta.TabStop = false;
            // 
            // pnlControlesFanta
            // 
            this.pnlControlesFanta.Controls.Add(this.mtbQuantidadeFanta);
            this.pnlControlesFanta.Controls.Add(this.ptbExcFanta);
            this.pnlControlesFanta.Controls.Add(this.ptbAddFanta);
            this.pnlControlesFanta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesFanta.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesFanta.Name = "pnlControlesFanta";
            this.pnlControlesFanta.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesFanta.TabIndex = 100007;
            // 
            // mtbQuantidadeFanta
            // 
            this.mtbQuantidadeFanta.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeFanta.Mask = "000";
            this.mtbQuantidadeFanta.Name = "mtbQuantidadeFanta";
            this.mtbQuantidadeFanta.ReadOnly = true;
            this.mtbQuantidadeFanta.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeFanta.TabIndex = 100012;
            this.mtbQuantidadeFanta.Text = "0";
            this.mtbQuantidadeFanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcFanta
            // 
            this.ptbExcFanta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcFanta.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcFanta.Image")));
            this.ptbExcFanta.Location = new System.Drawing.Point(12, 8);
            this.ptbExcFanta.Name = "ptbExcFanta";
            this.ptbExcFanta.Size = new System.Drawing.Size(20, 20);
            this.ptbExcFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcFanta.TabIndex = 100011;
            this.ptbExcFanta.TabStop = false;
            this.ptbExcFanta.Click += new System.EventHandler(this.ptbExcFanta_Click);
            // 
            // ptbAddFanta
            // 
            this.ptbAddFanta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddFanta.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddFanta.Image")));
            this.ptbAddFanta.Location = new System.Drawing.Point(67, 8);
            this.ptbAddFanta.Name = "ptbAddFanta";
            this.ptbAddFanta.Size = new System.Drawing.Size(20, 20);
            this.ptbAddFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddFanta.TabIndex = 100010;
            this.ptbAddFanta.TabStop = false;
            this.ptbAddFanta.Click += new System.EventHandler(this.ptbAddFanta_Click);
            // 
            // lblBebidaFanta
            // 
            this.lblBebidaFanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaFanta.Location = new System.Drawing.Point(2, 89);
            this.lblBebidaFanta.Name = "lblBebidaFanta";
            this.lblBebidaFanta.Size = new System.Drawing.Size(95, 21);
            this.lblBebidaFanta.TabIndex = 100006;
            this.lblBebidaFanta.Text = "FANTA";
            this.lblBebidaFanta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBebidaSprite
            // 
            this.pnlBebidaSprite.Controls.Add(this.imgBebidaSprite);
            this.pnlBebidaSprite.Controls.Add(this.pnlControlesSprite);
            this.pnlBebidaSprite.Controls.Add(this.lblBebidaSprite);
            this.pnlBebidaSprite.Location = new System.Drawing.Point(7, 7);
            this.pnlBebidaSprite.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlBebidaSprite.Name = "pnlBebidaSprite";
            this.pnlBebidaSprite.Size = new System.Drawing.Size(98, 147);
            this.pnlBebidaSprite.TabIndex = 100042;
            // 
            // imgBebidaSprite
            // 
            this.imgBebidaSprite.Image = ((System.Drawing.Image)(resources.GetObject("imgBebidaSprite.Image")));
            this.imgBebidaSprite.Location = new System.Drawing.Point(6, 5);
            this.imgBebidaSprite.Margin = new System.Windows.Forms.Padding(5);
            this.imgBebidaSprite.Name = "imgBebidaSprite";
            this.imgBebidaSprite.Size = new System.Drawing.Size(87, 79);
            this.imgBebidaSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBebidaSprite.TabIndex = 100008;
            this.imgBebidaSprite.TabStop = false;
            // 
            // pnlControlesSprite
            // 
            this.pnlControlesSprite.Controls.Add(this.mtbQuantidadeSprite);
            this.pnlControlesSprite.Controls.Add(this.ptbExcSprite);
            this.pnlControlesSprite.Controls.Add(this.ptbAddSprite);
            this.pnlControlesSprite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControlesSprite.Location = new System.Drawing.Point(0, 113);
            this.pnlControlesSprite.Name = "pnlControlesSprite";
            this.pnlControlesSprite.Size = new System.Drawing.Size(98, 34);
            this.pnlControlesSprite.TabIndex = 100007;
            // 
            // mtbQuantidadeSprite
            // 
            this.mtbQuantidadeSprite.Location = new System.Drawing.Point(35, 8);
            this.mtbQuantidadeSprite.Mask = "000";
            this.mtbQuantidadeSprite.Name = "mtbQuantidadeSprite";
            this.mtbQuantidadeSprite.ReadOnly = true;
            this.mtbQuantidadeSprite.Size = new System.Drawing.Size(29, 20);
            this.mtbQuantidadeSprite.TabIndex = 100012;
            this.mtbQuantidadeSprite.Text = "0";
            this.mtbQuantidadeSprite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbExcSprite
            // 
            this.ptbExcSprite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExcSprite.Image = ((System.Drawing.Image)(resources.GetObject("ptbExcSprite.Image")));
            this.ptbExcSprite.Location = new System.Drawing.Point(12, 8);
            this.ptbExcSprite.Name = "ptbExcSprite";
            this.ptbExcSprite.Size = new System.Drawing.Size(20, 20);
            this.ptbExcSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExcSprite.TabIndex = 100011;
            this.ptbExcSprite.TabStop = false;
            this.ptbExcSprite.Click += new System.EventHandler(this.ptbExcSprite_Click);
            // 
            // ptbAddSprite
            // 
            this.ptbAddSprite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAddSprite.Image = ((System.Drawing.Image)(resources.GetObject("ptbAddSprite.Image")));
            this.ptbAddSprite.Location = new System.Drawing.Point(67, 8);
            this.ptbAddSprite.Name = "ptbAddSprite";
            this.ptbAddSprite.Size = new System.Drawing.Size(20, 20);
            this.ptbAddSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddSprite.TabIndex = 100010;
            this.ptbAddSprite.TabStop = false;
            this.ptbAddSprite.Click += new System.EventHandler(this.ptbAddSprite_Click);
            // 
            // lblBebidaSprite
            // 
            this.lblBebidaSprite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaSprite.Location = new System.Drawing.Point(15, 89);
            this.lblBebidaSprite.Name = "lblBebidaSprite";
            this.lblBebidaSprite.Size = new System.Drawing.Size(68, 21);
            this.lblBebidaSprite.TabIndex = 100006;
            this.lblBebidaSprite.Text = "SPRITE";
            this.lblBebidaSprite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarPedido.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnRegistrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPedido.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRegistrarPedido.Location = new System.Drawing.Point(673, 492);
            this.btnRegistrarPedido.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(154, 39);
            this.btnRegistrarPedido.TabIndex = 100046;
            this.btnRegistrarPedido.Text = "Registrar Pedido";
            this.btnRegistrarPedido.UseVisualStyleBackColor = false;
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesas.Location = new System.Drawing.Point(12, 80);
            this.lblMesas.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(76, 25);
            this.lblMesas.TabIndex = 100047;
            this.lblMesas.Text = "MESA";
            // 
            // cmbMesas
            // 
            this.cmbMesas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cmbMesas.BackColor = System.Drawing.Color.Bisque;
            this.cmbMesas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbMesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesas.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cmbMesas.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cmbMesas.Location = new System.Drawing.Point(17, 108);
            this.cmbMesas.Name = "cmbMesas";
            this.cmbMesas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMesas.Size = new System.Drawing.Size(287, 32);
            this.cmbMesas.TabIndex = 100048;
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparTudo.FlatAppearance.BorderSize = 0;
            this.btnLimparTudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimparTudo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTudo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.ForeColor = System.Drawing.Color.Red;
            this.btnLimparTudo.Location = new System.Drawing.Point(673, 108);
            this.btnLimparTudo.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(154, 39);
            this.btnLimparTudo.TabIndex = 100049;
            this.btnLimparTudo.Text = "Limpar";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precounitarioDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 298);
            this.dataGridView1.TabIndex = 100050;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precounitarioDataGridViewTextBoxColumn
            // 
            this.precounitarioDataGridViewTextBoxColumn.DataPropertyName = "preco_unitario";
            this.precounitarioDataGridViewTextBoxColumn.HeaderText = "preco_unitario";
            this.precounitarioDataGridViewTextBoxColumn.Name = "precounitarioDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.lanchoneteDataSet;
            // 
            // lanchoneteDataSet
            // 
            this.lanchoneteDataSet.DataSetName = "lanchoneteDataSet";
            this.lanchoneteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // btnNew_Item
            // 
            this.btnNew_Item.Location = new System.Drawing.Point(707, 176);
            this.btnNew_Item.Name = "btnNew_Item";
            this.btnNew_Item.Size = new System.Drawing.Size(136, 41);
            this.btnNew_Item.TabIndex = 100051;
            this.btnNew_Item.Text = "ENVIAR PARA PEDIDO";
            this.btnNew_Item.UseVisualStyleBackColor = true;
            this.btnNew_Item.Click += new System.EventHandler(this.btnNew_Item_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(977, 549);
            this.Controls.Add(this.btnNew_Item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.cmbMesas);
            this.Controls.Add(this.lblMesas);
            this.Controls.Add(this.btnRegistrarPedido);
            this.Controls.Add(this.panelLogo);
            this.Name = "frmProdutos";
            this.Text = "PRODUTOS";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanchoneteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.ComboBox cmbMesas;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lanchoneteDataSet lanchoneteDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private lanchoneteDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precounitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNew_Item;
    }
}
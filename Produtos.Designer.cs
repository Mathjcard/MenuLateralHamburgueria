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
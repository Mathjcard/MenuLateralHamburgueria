using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuLateralHamburgueria.Controller;
using MenuLateralHamburgueria.Models;

namespace MenuLateralHamburgueria.Views.TelaProdutos
{
    public partial class Index : Form
    {
        private readonly ProdutoController produtoController = new ProdutoController();

        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            AtualizarTabelaProdutos();
        }

        private void AtualizarTabelaProdutos()
        {
            dgvProdutos.DataSource = produtoController.ListaProdutos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //validarCamposCadastro();
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbTipo.Text))
            {
                MessageBox.Show("Informe o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipo.Focus();
                return;
            }

            txtPrecoUni.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrWhiteSpace(txtPrecoUni.Text))
            {
                MessageBox.Show("Informe o preço do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecoUni.Focus();
                return;
            }

            txtPrecoUni.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            var produto = new Produtos
            {
                Nome = txtNome.Text,
                Tipo = cmbTipo.Text,
                PrecoUnitario = Convert.ToDecimal(txtPrecoUni.Text),
            };

            try
            {
                produtoController.CadastrarProdutos(produto);
                MessageBox.Show("Produto salvo com sucesso!", "Contato Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarTabelaProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs linhaSelecionada)
        {
            if (linhaSelecionada .RowIndex >= 0)
            {
                var produtoSelecionado = dgvProdutos.Rows[linhaSelecionada.RowIndex].DataBoundItem as Produtos;
                
                if (produtoSelecionado != null)
                {
                    txtNome.Text = produtoSelecionado.Nome;
                    cmbTipo.Text = produtoSelecionado.Tipo;
                    txtPrecoUni.Text = produtoSelecionado.PrecoUnitario.ToString();
                }
                MessageBox.Show("Linha selecionada: " + produtoSelecionado);

            }
            btnEditar.Visible = true;
        }
    }
}

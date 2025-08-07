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
using MenuLateralHamburgueria.Service;

namespace MenuLateralHamburgueria
{
    public partial class frmProdutos : Form
    {
        private readonly ProdutoService produtoService = new ProdutoService();

        public frmProdutos()
        {
            InitializeComponent();
        }

        /** Adicionar e remover valor - MIAMI */
        private int contaQuantidadeMiami = 0;
        private void ptbAddMiami_Click(object sender, EventArgs e)
        {
            contaQuantidadeMiami = produtoService.adicionaQuantidadeProduto(contaQuantidadeMiami);
            mtbQuantidadeMiami.Text = Convert.ToString(contaQuantidadeMiami);
        }
        private void ptbExcMiami_Click(object sender, EventArgs e)
        {
            contaQuantidadeMiami = produtoService.removeQuantidadeProduto(contaQuantidadeMiami);
            mtbQuantidadeMiami.Text = Convert.ToString(contaQuantidadeMiami);
        }

        /** Adicionar e remover valor - NOVA YORK */
        private int contaQuantidadeNy = 0;
        private void ptbAddNovaYork_Click(object sender, EventArgs e)
        {
            contaQuantidadeNy = produtoService.adicionaQuantidadeProduto(contaQuantidadeNy);
            mtbQuantidadeNovaYork.Text = Convert.ToString(contaQuantidadeNy);
        }
        private void ptbExcNovaYork_Click(object sender, EventArgs e)
        {
            contaQuantidadeNy = produtoService.removeQuantidadeProduto(contaQuantidadeNy);
            mtbQuantidadeNovaYork.Text = Convert.ToString(contaQuantidadeNy);
        }

        /** Adicionar e remover valor - DETROIT */
        private int contaQuantidadeDetroit = 0;
        private void ptbAddDetroit_Click(object sender, EventArgs e)
        {
            contaQuantidadeDetroit = produtoService.adicionaQuantidadeProduto(contaQuantidadeDetroit);
            mtbQuantidadeDetroit.Text = Convert.ToString(contaQuantidadeDetroit);
        }
        private void ptbExcDetroit_Click(object sender, EventArgs e)
        {
            contaQuantidadeDetroit = produtoService.removeQuantidadeProduto(contaQuantidadeDetroit);
            mtbQuantidadeDetroit.Text = Convert.ToString(contaQuantidadeDetroit);
        }

        /** Adicionar e remover valor - AMAZONAS */
        private int contaQuantidadeAmazonas = 0;
        private void ptbAddAmazonas_Click(object sender, EventArgs e)
        {
            contaQuantidadeAmazonas = produtoService.adicionaQuantidadeProduto(contaQuantidadeAmazonas);
            mtbQuantidadeAmazonas.Text = Convert.ToString(contaQuantidadeAmazonas);
        }
        private void ptbExcAmazonas_Click(object sender, EventArgs e)
        {
            contaQuantidadeAmazonas = produtoService.removeQuantidadeProduto(contaQuantidadeAmazonas);
            mtbQuantidadeAmazonas.Text = Convert.ToString(contaQuantidadeAmazonas);
        }

        /** Adicionar e remover valor - PAULISTA */
        private int contaQuantidadePaulista = 0;
        private void ptbAddPaulista_Click(object sender, EventArgs e)
        {
            contaQuantidadePaulista = produtoService.adicionaQuantidadeProduto(contaQuantidadePaulista);
            mtbQuantidadePaulista.Text = Convert.ToString(contaQuantidadePaulista);
        }
        private void ptbExcPaulista_Click(object sender, EventArgs e)
        {
            contaQuantidadePaulista = produtoService.removeQuantidadeProduto(contaQuantidadePaulista);
            mtbQuantidadePaulista.Text = Convert.ToString(contaQuantidadePaulista);
        }

        /** Adicionar e remover valor - MILÃO */
        private int contaQuantidadeMilao = 0;
        private void ptbAddMilao_Click(object sender, EventArgs e)
        {
            contaQuantidadeMilao = produtoService.adicionaQuantidadeProduto(contaQuantidadeMilao);
            mtbQuantidadeMilao.Text = Convert.ToString(contaQuantidadeMilao);
        }
        private void ptbExcMilao_Click(object sender, EventArgs e)
        {
            contaQuantidadeMilao = produtoService.removeQuantidadeProduto(contaQuantidadeMilao);
            mtbQuantidadeMilao.Text = Convert.ToString(contaQuantidadeMilao);
        }


        /** Adicionar e remover valor - SPRITE */
        private int contaQuantidadeSprite = 0;
        private void ptbAddSprite_Click(object sender, EventArgs e)
        {
            contaQuantidadeSprite = produtoService.adicionaQuantidadeProduto(contaQuantidadeSprite);
            mtbQuantidadeSprite.Text = Convert.ToString(contaQuantidadeSprite);
        }
        private void ptbExcSprite_Click(object sender, EventArgs e)
        {
            contaQuantidadeSprite = produtoService.removeQuantidadeProduto(contaQuantidadeSprite);
            mtbQuantidadeSprite.Text = Convert.ToString(contaQuantidadeSprite);
        }

        /** Adicionar e remover valor - FANTA */
        private int contaQuantidadeFanta = 0;
        private void ptbAddFanta_Click(object sender, EventArgs e)
        {
            contaQuantidadeFanta = produtoService.adicionaQuantidadeProduto(contaQuantidadeFanta);
            mtbQuantidadeFanta.Text = Convert.ToString(contaQuantidadeFanta);
        }
        private void ptbExcFanta_Click(object sender, EventArgs e)
        {
            contaQuantidadeFanta = produtoService.removeQuantidadeProduto(contaQuantidadeFanta);
            mtbQuantidadeFanta.Text = Convert.ToString(contaQuantidadeFanta);
        }

        /** Adicionar e remover valor - COCA-COLA */
        private int contaQuantidadeCoca = 0;
        private void ptbAddCoca_Click(object sender, EventArgs e)
        {
            contaQuantidadeCoca = produtoService.adicionaQuantidadeProduto(contaQuantidadeCoca);
            mtbQuantidadeCoca.Text = Convert.ToString(contaQuantidadeCoca);
        }
        private void ptbExcCoca_Click(object sender, EventArgs e)
        {
            contaQuantidadeCoca = produtoService.removeQuantidadeProduto(contaQuantidadeCoca);
            mtbQuantidadeCoca.Text = Convert.ToString(contaQuantidadeCoca);
        }

        /** Adicionar e remover valor - PEPSI */
        private int contaQuantidadePepsi = 0;
        private void ptbAddPepsi_Click(object sender, EventArgs e)
        {
            contaQuantidadePepsi = produtoService.adicionaQuantidadeProduto(contaQuantidadePepsi);
            mtbQuantidadePepsi.Text = Convert.ToString(contaQuantidadePepsi);
        }
        private void ptbExcPepsi_Click(object sender, EventArgs e)
        {
            contaQuantidadePepsi = produtoService.removeQuantidadeProduto(contaQuantidadePepsi);
            mtbQuantidadePepsi.Text = Convert.ToString(contaQuantidadePepsi);
        }

        /** Adicionar e remover valor - GUARANA */
        private int contaQuantidadeGuarana = 0;
        private void ptbAddGuarana_Click(object sender, EventArgs e)
        {
            contaQuantidadeGuarana = produtoService.adicionaQuantidadeProduto(contaQuantidadeGuarana);
            mtbQuantidadeGuarana.Text = Convert.ToString(contaQuantidadeGuarana);
        }
        private void ptbExcGuarana_Click(object sender, EventArgs e)
        {
            contaQuantidadeGuarana = produtoService.removeQuantidadeProduto(contaQuantidadeGuarana);
            mtbQuantidadeGuarana.Text = Convert.ToString(contaQuantidadeGuarana);
        }

        /** Adicionar e remover valor - SUCO */
        private int contaQuantidadeSuco = 0;
        private void ptbAddSuco_Click(object sender, EventArgs e)
        {
            contaQuantidadeSuco = produtoService.adicionaQuantidadeProduto(contaQuantidadeSuco);
            mtbQuantidadeSuco.Text = Convert.ToString(contaQuantidadeSuco);
        }
        private void ptbExcSuco_Click(object sender, EventArgs e)
        {
            contaQuantidadeSuco = produtoService.removeQuantidadeProduto(contaQuantidadeSuco);
            mtbQuantidadeSuco.Text = Convert.ToString(contaQuantidadeSuco);
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            LimparMaskedTextBoxes(this);
            // Zerar os contadores dos lanches
            contaQuantidadeMiami = 0;
            contaQuantidadeNy = 0;
            contaQuantidadeDetroit = 0;
            contaQuantidadeAmazonas = 0;
            contaQuantidadePaulista = 0;
            contaQuantidadeMilao = 0;
            // Zerar os contadores dos refrigerantes
            contaQuantidadeSprite = 0;
            contaQuantidadeFanta = 0;
            contaQuantidadeCoca = 0;
            contaQuantidadePepsi = 0;
            contaQuantidadeGuarana = 0;
            contaQuantidadeSuco = 0;
        }

        private void LimparMaskedTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is MaskedTextBox && ctrl.Name.StartsWith("mtbQuantidade"))
                {
                    ((MaskedTextBox)ctrl).Text = "0";
                }

                // Se tiver filhos, chama recursivamente
                if (ctrl.HasChildren)
                {
                    LimparMaskedTextBoxes(ctrl);
                }
            }
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbMesas.Text))
            {
                MessageBox.Show("Selecione uma mesa para registrar o pedido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mesa = cmbMesas.Text;

            var todosProdutos = new[]
            {
                mtbQuantidadeMiami, mtbQuantidadeNovaYork, mtbQuantidadeDetroit,
                mtbQuantidadeAmazonas, mtbQuantidadePaulista, mtbQuantidadeMilao,

                mtbQuantidadeSprite, mtbQuantidadeFanta, mtbQuantidadeCoca,
                mtbQuantidadePepsi, mtbQuantidadeGuarana, mtbQuantidadeSuco
            };

            if (todosProdutos.All(quantidade => quantidade.Text == "0"))
            {
                MessageBox.Show("Informe pelo menos um produto!\n Pedido não registrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var camposDiferentesDeZero = todosProdutos.Where(produto => produto.Text != "0").ToList();
            for (int i = 0; i < camposDiferentesDeZero.Count; i++)
            {
                MessageBox.Show($"Nome do produto - {camposDiferentesDeZero[i].Name} \n" +
                                $"Quantidade do Produto - {camposDiferentesDeZero[i].Text}\n" +
                                $"Mesa - {mesa}");

            }

            MessageBox.Show($"Pedido registrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}

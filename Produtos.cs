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
            if (contaQuantidadeDetroit < 10)
            {
                contaQuantidadeDetroit += 1;
                mtbQuantidadeDetroit.Text = Convert.ToString(contaQuantidadeDetroit);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcDetroit_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeDetroit <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeDetroit -= 1;
                mtbQuantidadeDetroit.Text = Convert.ToString(contaQuantidadeDetroit);
            }
        }

        /** Adicionar e remover valor - AMAZONAS */
        private int contaQuantidadeAmazonas = 0;
        private void ptbAddAmazonas_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeAmazonas < 10)
            {
                contaQuantidadeAmazonas += 1;
                mtbQuantidadeAmazonas.Text = Convert.ToString(contaQuantidadeAmazonas);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcAmazonas_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeAmazonas <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeAmazonas -= 1;
                mtbQuantidadeAmazonas.Text = Convert.ToString(contaQuantidadeAmazonas);
            }
        }

        /** Adicionar e remover valor - PAULISTA */
        private int contaQuantidadePaulista = 0;
        private void ptbAddPaulista_Click(object sender, EventArgs e)
        {
            if (contaQuantidadePaulista < 10)
            {
                contaQuantidadePaulista += 1;
                mtbQuantidadePaulista.Text = Convert.ToString(contaQuantidadePaulista);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcPaulista_Click(object sender, EventArgs e)
        {
            if (contaQuantidadePaulista <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadePaulista -= 1;
                mtbQuantidadePaulista.Text = Convert.ToString(contaQuantidadePaulista);
            }
        }

        /** Adicionar e remover valor - MILÃO */
        private int contaQuantidadeMilao = 0;
        private void ptbAddMilao_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeMilao < 10)
            {
                contaQuantidadeMilao += 1;
                mtbQuantidadeMilao.Text = Convert.ToString(contaQuantidadeMilao);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcMilao_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeMilao <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeMilao -= 1;
                mtbQuantidadeMilao.Text = Convert.ToString(contaQuantidadeMilao);
            }
        }


        /** Adicionar e remover valor - SPRITE */
        private int contaQuantidadeSprite = 0;
        private void ptbAddSprite_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeSprite < 10)
            {
                contaQuantidadeSprite += 1;
                mtbQuantidadeSprite.Text = Convert.ToString(contaQuantidadeSprite);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcSprite_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeSprite <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeSprite -= 1;
                mtbQuantidadeSprite.Text = Convert.ToString(contaQuantidadeSprite);
            }
        }

        /** Adicionar e remover valor - FANTA */
        private int contaQuantidadeFanta = 0;
        private void ptbAddFanta_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeFanta < 10)
            {
                contaQuantidadeFanta += 1;
                mtbQuantidadeFanta.Text = Convert.ToString(contaQuantidadeFanta);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcFanta_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeFanta <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeFanta -= 1;
                mtbQuantidadeFanta.Text = Convert.ToString(contaQuantidadeFanta);
            }
        }

        /** Adicionar e remover valor - COCA-COLA */
        private int contaQuantidadeCoca = 0;
        private void ptbAddCoca_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeCoca < 10)
            {
                contaQuantidadeCoca += 1;
                mtbQuantidadeCoca.Text = Convert.ToString(contaQuantidadeCoca);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcCoca_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeCoca <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeCoca -= 1;
                mtbQuantidadeCoca.Text = Convert.ToString(contaQuantidadeCoca);
            }
        }

        /** Adicionar e remover valor - PEPSI */
        private int contaQuantidadePepsi = 0;
        private void ptbAddPepsi_Click(object sender, EventArgs e)
        {
            if (contaQuantidadePepsi < 10)
            {
                contaQuantidadePepsi += 1;
                mtbQuantidadePepsi.Text = Convert.ToString(contaQuantidadePepsi);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcPepsi_Click(object sender, EventArgs e)
        {
            if (contaQuantidadePepsi <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadePepsi -= 1;
                mtbQuantidadePepsi.Text = Convert.ToString(contaQuantidadePepsi);
            }
        }

        /** Adicionar e remover valor - GUARANA */
        private int contaQuantidadeGuarana = 0;
        private void ptbAddGuarana_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeGuarana < 10)
            {
                contaQuantidadeGuarana += 1;
                mtbQuantidadeGuarana.Text = Convert.ToString(contaQuantidadeGuarana);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcGuarana_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeGuarana <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeGuarana -= 1;
                mtbQuantidadeGuarana.Text = Convert.ToString(contaQuantidadeGuarana);
            }
        }

        /** Adicionar e remover valor - SUCO */
        private int contaQuantidadeSuco = 0;
        private void ptbAddSuco_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeSuco < 10)
            {
                contaQuantidadeSuco += 1;
                mtbQuantidadeSuco.Text = Convert.ToString(contaQuantidadeSuco);
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcSuco_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeSuco <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeSuco -= 1;
                mtbQuantidadeSuco.Text = Convert.ToString(contaQuantidadeSuco);
            }
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

        private void frmProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}

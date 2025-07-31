using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLateralHamburgueria
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        /** Adicionar e remover valor - MIAMI */
        private int contaQuantidadeMiami = 0;
        private void ptbAddMiami_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeMiami < 10)
            {
                contaQuantidadeMiami += 1;
                mtbQuantidadeMiami.Text = Convert.ToString(contaQuantidadeMiami);
            } else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcMiami_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeMiami <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                contaQuantidadeMiami -= 1;
                mtbQuantidadeMiami.Text = Convert.ToString(contaQuantidadeMiami);
            }
        }

        /** Adicionar e remover valor - NOVA YORK */
        private int contaQuantidadeNy = 0;
        private void ptbAddNovaYork_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeNy < 10)
            {
                contaQuantidadeNy += 1;
                mtbQuantidadeNovaYork.Text = Convert.ToString(contaQuantidadeNy);
            }else
            {
                MessageBox.Show("Quantidade máxima atingida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ptbExcNovaYork_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeNy <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                contaQuantidadeNy -= 1;
                mtbQuantidadeNovaYork.Text = Convert.ToString(contaQuantidadeNy);
            }
        }

        /** Adicionar e remover valor - DETROIT */
        private int contaQuantidadeDetroit = 0;
        private void ptbAddDetroit_Click(object sender, EventArgs e)
        {
            if (contaQuantidadeDetroit < 10)
            {
                contaQuantidadeDetroit += 1;
                mtdQuantidadeDetroit.Text = Convert.ToString(contaQuantidadeDetroit);
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
                mtdQuantidadeDetroit.Text = Convert.ToString(contaQuantidadeDetroit);
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
    }
}

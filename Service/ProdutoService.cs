using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLateralHamburgueria.Service
{
    public class ProdutoService
    {
        public int adicionaQuantidadeProduto(int quantidade)
        {
            if (quantidade < 10)
            {
                quantidade += 1;
            }
            else
            {
                MessageBox.Show("Quantidade máxima atingida!");
            }

            return quantidade;
        }

        public int removeQuantidadeProduto(int quantidade)
        {
            if (quantidade <= 0)
            {
                MessageBox.Show("Quantidade não informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                quantidade -= 1;
            }

            return quantidade;
        }
    }
}

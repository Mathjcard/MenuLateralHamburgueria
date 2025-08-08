using MenuLateralHamburgueria.DAO;
using MenuLateralHamburgueria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLateralHamburgueria.Controller
{
    public class PedidoProdutoController
    {
        public void SalvarPedidoProduto(PedidosProdutos pedidoProduto)
        {
            PedidosProdutosDAO.Cadastrar(pedidoProduto);
        }
    }
}

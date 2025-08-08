using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLateralHamburgueria.DAO;
using MenuLateralHamburgueria.Models;

namespace MenuLateralHamburgueria.Controller
{
    public class ProdutoController
    {
        public List<Produtos> ListaProdutos()
        {
            return ProdutoDAO.Listar();
        }

        public void CadastrarProdutos(Produtos produtos)
        {
            ProdutoDAO.Cadastrar(produtos);
        }

    }
}

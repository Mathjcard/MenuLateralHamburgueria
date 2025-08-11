using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLateralHamburgueria.DAO;
using MenuLateralHamburgueria.Models;


namespace MenuLateralHamburgueria.Controller
{
    public class ProdutosController
    {
        public List<Produtos> ListarProdutos()
        {
            return DAO.ProdutosDAO.Listar();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLateralHamburgueria.Models
{
    public class PedidosProdutos
    {
        public int Id { get; set; }
        public int Mesa { get; set; }
        public int Produto_id { get; set; }
        public int Pedido_id { get; set; }
        public int Quantidade { get; set; }
    }
}

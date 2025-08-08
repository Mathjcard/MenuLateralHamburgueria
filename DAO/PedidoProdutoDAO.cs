using MenuLateralHamburgueria.Models;
using MenuLateralHamburgueria.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLateralHamburgueria.DAO
{
    public static class PedidosProdutosDAO
    {
        public static void Cadastrar(PedidosProdutos pedidosProdutos)
        {
            var conexao = Conexao.ObterConexao();
            conexao.Open();

            var sql = "INSERT INTO pedidos_produtos (mesa, produto_id, pedido_id, quantidade) VALUES (@mesa, @produto_id, @pedido_id, @quantidade)";

            var command = new SqlCommand(sql, conexao);

            command.Parameters.AddWithValue("@mesa", pedidosProdutos.Mesa);
            command.Parameters.AddWithValue("@produto_id", pedidosProdutos.Produto_id);
            command.Parameters.AddWithValue("@pedido_id", pedidosProdutos.Pedido_id);
            command.Parameters.AddWithValue("@quantidade", pedidosProdutos.Quantidade);

            command.ExecuteNonQuery();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLateralHamburgueria.Models;
using MenuLateralHamburgueria.Utils;
using System.Data.SqlClient;


namespace MenuLateralHamburgueria.DAO
{
    internal class ProdutosDAO
    {
        public static List<Produtos> Listar()
        {
            var lista = new List<Produtos>();
            var comn = Conexao.ObterConexao();
            comn.Open();
            var sql = "SELECT*FROM Produtos";
            var cmd = new SqlCommand(sql, comn);
            using (var listaDados = cmd.ExecuteReader())

            {
                while (listaDados.Read())
                {
                    lista.Add(new Produtos
                    {
                        Id = (int)listaDados["id"],
                        Nome = listaDados["nome"].ToString(),
                        Preco_unitario = listaDados["preco_unitario"].ToString(),
                        Tipo = listaDados["tipo"].ToString(),
                        Quantidade = listaDados["quantidade"].ToString(),
                        Data_cadastro = listaDados[ "data_cadastro"].ToString(),


                    });
                }
                return lista;
            }
        }
        public static void Newproduto_pedido(Produtos produto)
        {

            var comn = Conexao.ObterConexao();
            comn.Open();
            var sql = "INSERT INTO Pedidos_Produtos ( PedidoID,  ProdutoID,   Quantidade,   PRIMARY KEY (PedidoID, ProdutoID), FO (PedidoID) REFERENCES Pedidos(PedidoID),   FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID))";
            var cmd = new SqlCommand(sql, comn);
            cmd.Parameters.AddWithValue("@nome", produto.Nome);
            cmd.Parameters.AddWithValue("@preco_unitario", produto.Preco_unitario);
            cmd.Parameters.AddWithValue("@tipo", produto.Tipo);
            cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            cmd.Parameters.AddWithValue("@data_cadastro", produto.Data_cadastro);

            cmd.ExecuteNonQuery();
        }
    }
}



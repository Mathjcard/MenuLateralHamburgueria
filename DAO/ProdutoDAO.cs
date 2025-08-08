using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLateralHamburgueria.Models;
using MenuLateralHamburgueria.Utils;

namespace MenuLateralHamburgueria.DAO
{
    public class ProdutoDAO
    {
        public static List<Produtos> Listar()
        {
            var lista = new List<Produtos>();

            var conexao = Conexao.ObterConexao();
            conexao.Open();

            var sql = "SELECT * FROM produtos";

            var command = new SqlCommand(sql, conexao);

            var reader = command.ExecuteReader();

            while (reader.Read()) /** Enquanto o comando tiver um valor que não foi lido, continua a execução */
            {
                lista.Add(new Produtos
                {
                    Id = (int)reader["id"],
                    Nome = reader["nome"].ToString(),
                    PrecoUnitario = (decimal)reader["preco_unitario"],
                    Tipo = reader["tipo"].ToString(),
                });
            }

            return lista;
        }

        public static void Cadastrar(Produtos produtos)
        {
            var conexao = Conexao.ObterConexao();
            conexao.Open();

            var sql = "INSERT INTO produtos (nome, preco_unitario, tipo) VALUES (@nome, @preco_unitario, @tipo)";

            var command = new SqlCommand(sql, conexao);

            command.Parameters.AddWithValue("@nome", produtos.Nome);
            command.Parameters.AddWithValue("@preco_unitario", produtos.PrecoUnitario);
            command.Parameters.AddWithValue("@tipo", produtos.Tipo);
            
            command.ExecuteNonQuery();
        }
    }
}

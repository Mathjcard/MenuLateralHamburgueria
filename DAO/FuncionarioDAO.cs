using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MenuLateralHamburgueria.Models;
using MenuLateralHamburgueria.Utils;

namespace MenuLateralHamburgueria.DAO
{
    public static class FuncionarioDAO
    {
        public static void Inserir(Funcionarios funcionario)
        {
            var conexao = Conexao.ObterConexao();
            conexao.Open();

            var sql = "INSERT INTO funcionarios (nome, nome_usuario, email, senha, cargo) VALUES (@nome, @nome_usuario, @email, @senha, @cargo)";

            var command = new SqlCommand(sql, conexao);

            command.Parameters.AddWithValue("@nome", funcionario.Nome);
            command.Parameters.AddWithValue("@nome_usuario", funcionario.NomeUsuario);
            command.Parameters.AddWithValue("@email", funcionario.Email);
            command.Parameters.AddWithValue("@senha", funcionario.Senha);
            command.Parameters.AddWithValue("@cargo", funcionario.Cargo);

            command.ExecuteNonQuery();
        }

        public static void Atualizar(Funcionarios funcionario) 
        {
            var conexao = Conexao.ObterConexao();
            conexao.Open();

            var sql = "UPDATE funcionarios SET senha=@senha WHERE nome_usuario=@nome_usuario";

            var command = new SqlCommand(sql, conexao);

            command.Parameters.AddWithValue("@nome_usuario", funcionario.NomeUsuario);
            command.Parameters.AddWithValue("@senha", funcionario.Senha);

            command.ExecuteNonQuery();
        }
    }
}

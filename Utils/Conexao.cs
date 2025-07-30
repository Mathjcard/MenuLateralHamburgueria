using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLateralHamburgueria.Utils
{
    public static class Conexao
    {
        private static string dadosConexao = @"Data Source=MAR0625654W10-1;Initial Catalog=lanchonete;
            User ID=sa;Password=senac2025;
            TrustServerCertificate=True;Integrated Security=false";

        public static SqlConnection ObterConexao()
        {
            return new SqlConnection(dadosConexao);
        }
    }
}

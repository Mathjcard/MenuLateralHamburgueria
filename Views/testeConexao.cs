using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuLateralHamburgueria.Utils;

namespace MenuLateralHamburgueria.Views
{
    public partial class testeConexao : Form
    {
        public testeConexao()
        {
            InitializeComponent();
        }

        private void btnTestaConexao_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estou aqui no Testar conexão");
            try
            {
                SqlConnection conexao = Conexao.ObterConexao();

                conexao.Open();

                MessageBox.Show("Conexão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro ao tentar conectar ao banco {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

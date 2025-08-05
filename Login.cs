using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLateralHamburgueria
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Entra direto na tela de Menu Principal
            this.Hide();
            new frmPrincipal().ShowDialog();
            this.Close();


            ////VERIFICAÇÃO DE CAMPOS E SE TEM ESPACO EM BRANCO
            //if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            //{
            //    MessageBox.Show("Por favor, preencha o Login e a Senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            ////VERIFICAÇÃO DE TAMANHO DA SENHA
            //if (txtSenha.Text.Length < 6)
            //{
            //    MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

        }

        private void lblEsquciSenha_Click(object sender, EventArgs e)
        {
            frmEsquecerSenha frmEsquecerSenha = new frmEsquecerSenha();
            frmEsquecerSenha.ShowDialog();
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroUser frmCadastroUser = new frmCadastroUser();
            frmCadastroUser.ShowDialog();
        }

        private void boxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSenha.Checked)
            {

                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {

                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}

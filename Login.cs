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
            // Pula para o menu lateral sem validar nada
            frmPrincipal telaMenu = new frmPrincipal();
            telaMenu.Show();
            this.Hide();

            //VERIFICAÇÃO DE CAMPOS SE TEM ESPACO EM BRANCO
            //if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            //{
            //    MessageBox.Show("Por favor, preencha o Login e a Senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}

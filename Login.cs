using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuLateralHamburgueria.Controller;
using MenuLateralHamburgueria.Models;

namespace MenuLateralHamburgueria
{
    public partial class frmLogin : Form
    {
        private readonly FuncionarioController funcionarioController = new FuncionarioController();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Entra direto na tela de Menu Principal
            //frmPrincipal telaMenu = new frmPrincipal();
            //telaMenu.Show();
            //this.Hide();

            //VERIFICAÇÃO DE CAMPOS E SE TEM ESPACO EM BRANCO
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha o Login e a Senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //VERIFICAÇÃO DE TAMANHO DA SENHA
            if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               var funcionarioAutenticado =  funcionarioController.AutenticacaoLogin(txtLogin.Text, txtSenha.Text);
                if (funcionarioAutenticado.Count != 1)
                {
                    MessageBox.Show($"Usuário não encontrado ou senha incorreta!", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                MessageBox.Show($"Login Feito com sucesso! {funcionarioAutenticado.Count}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal telaMenu = new frmPrincipal();
                telaMenu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar realizar o login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

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
using MenuLateralHamburgueria.Service;

namespace MenuLateralHamburgueria
{
    public partial class frmLogin : Form
    {
        private readonly FuncionarioController funcionarioController = new FuncionarioController();

        private readonly LoginService loginService = new LoginService();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var resultadoValidacao = loginService.validaCamposLogin(txtLogin.Text, txtSenha.Text);

            if (resultadoValidacao)
            {
                try
                {
                    var funcionarioAutenticado = funcionarioController.AutenticacaoLogin(txtLogin.Text, txtSenha.Text);

                    if (funcionarioAutenticado.Count != 1)
                    {
                        MessageBox.Show("Usuário não encontrado ou senha incorreta!", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Login ok - fecha o login e sinaliza que deu certo
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao tentar realizar o login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

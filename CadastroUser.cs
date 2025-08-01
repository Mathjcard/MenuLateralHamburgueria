using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace MenuLateralHamburgueria
{
    public partial class frmCadastroUser : Form
    {
        public frmCadastroUser()
        {
            InitializeComponent();
        }

        private void btnCadastroUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtNomeUser.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmaSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação do formato do e-mail
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Por favor, informe um e-mail válido.", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação da senha com mínimo de 6 caracteres
            if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no mínimo 6 caracteres.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se as senhas conferem
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não conferem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        

        private void SenhaBox_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se os dois checkboxs estão marcados
            if (SenhaBox.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtConfirmaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtConfirmaSenha.UseSystemPasswordChar = true;
            }
        }
    }


}

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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SenhaBox_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se os dois checkboxs estão marcados
            if (SenhaBox.Checked)
            {
                txtSenhaPerfil.UseSystemPasswordChar = false;
                txtConfirmaSenhaPerfil.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaPerfil.UseSystemPasswordChar = true;
                txtConfirmaSenhaPerfil.UseSystemPasswordChar = true;
            }
        }

        private void btnSalvarPerfil_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmailPerfil.Text))
            {
                MessageBox.Show("Por favor, informe um e-mail válido.", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                       

            if (txtSenhaPerfil.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no mínimo 6 caracteres.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se as senhas conferem
            if (txtSenhaPerfil.Text != txtConfirmaSenhaPerfil.Text)
            {
                MessageBox.Show("As senhas não conferem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Perfil atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}

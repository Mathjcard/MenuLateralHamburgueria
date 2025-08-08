using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuLateralHamburgueria.DAO;

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
            if (string.IsNullOrWhiteSpace(txtNomePerfil.Text) || string.IsNullOrWhiteSpace(txtEmailPerfil.Text) || string.IsNullOrWhiteSpace(txtSenhaPerfil.Text) || string.IsNullOrWhiteSpace(txtConfirmaSenhaPerfil.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalvarPerfil.Enabled = true;
            txtNomePerfil.Focus();
            txtNomePerfil.Enabled = true;
            txtEmailPerfil.Enabled = true;
            txtSenhaPerfil.Enabled = true;
            txtConfirmaSenhaPerfil.Enabled = true;
            txtSenhaPerfil.UseSystemPasswordChar = true;
            txtConfirmaSenhaPerfil.UseSystemPasswordChar = true;
            SenhaBox.Checked = false;
            
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtNomePerfil.Enabled = false;
            txtEmailPerfil.Enabled = false;
            txtSenhaPerfil.Enabled = false;
            txtConfirmaSenhaPerfil.Enabled = false;
            btnSalvarPerfil.Enabled = false;
            SenhaBox.Checked = false;
            txtSenhaPerfil.UseSystemPasswordChar = true;
            txtConfirmaSenhaPerfil.UseSystemPasswordChar = true;
            txtUserPerfil.Enabled = false;

        }
    }
}

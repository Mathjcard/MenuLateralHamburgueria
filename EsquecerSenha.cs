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
    public partial class frmEsquecerSenha : Form
    {
        public frmEsquecerSenha()
        {
            InitializeComponent();
        }

        private void btnCadastroSenhaNova_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtNovaSenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmaNsenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNovaSenha.Text.Length < 6 || txtConfirmaNsenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no mínimo 6 caracteres.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                // Verificar se as senhas conferem
                if (txtNovaSenha.Text != txtConfirmaNsenha.Text)
            {
                MessageBox.Show("As senhas não conferem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

             this.Close();
        }

        private void boxSenha2_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se o checkbox está marcado
            if (boxSenha2.Checked)
            {
                txtNovaSenha.UseSystemPasswordChar = false;
                txtConfirmaNsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true;
                txtConfirmaNsenha.UseSystemPasswordChar = true;
            }
        }
    }
}

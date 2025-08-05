using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLateralHamburgueria.Service
{
    public class LoginService
    {
        public bool validaCamposLogin(string UserName, string Senha)
        {
            //VERIFICAÇÃO DE CAMPOS E SE TEM ESPACO EM BRANCO
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Senha))
            {
                MessageBox.Show("Por favor, preencha o Login e a Senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //VERIFICAÇÃO DE TAMANHO DA SENHA
            if (Senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

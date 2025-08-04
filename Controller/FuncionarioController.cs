using MenuLateralHamburgueria.DAO;
using MenuLateralHamburgueria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLateralHamburgueria.Controller
{
    public class FuncionarioController
    {
        public void SalvarFuncionario(Funcionarios funcionario)
        {
            FuncionarioDAO.Inserir(funcionario);
        }

        public void AtualizarSenhaFuncionario(Funcionarios funcionario)
        {
            FuncionarioDAO.Atualizar(funcionario);
        }
    }
}

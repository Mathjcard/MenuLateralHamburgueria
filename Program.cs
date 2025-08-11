using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuLateralHamburgueria;
using MenuLateralHamburgueria.Views;

namespace MenuLateralHamburgueria
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        [STAThread]
        static void Main()
        {      
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPrincipal());
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmPrincipal()); // só entra no menu se o login der certo
                }
            }
        }
    } 
}




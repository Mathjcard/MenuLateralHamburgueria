using MenulateralHamburgueria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuLateralHamburgueria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLogin telaLogin = new frmLogin();
            telaLogin.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCentro.Controls.Clear();
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.TopLevel = false;
            frmProdutos.FormBorderStyle = FormBorderStyle.None;
            frmProdutos.Dock = DockStyle.Fill;
            panelCentro.Controls.Add(frmProdutos);
            frmProdutos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCentro.Controls.Clear();
            frmPedidos frmPedidos = new frmPedidos();
            frmPedidos.TopLevel = false;
            frmPedidos.FormBorderStyle = FormBorderStyle.None;
            frmPedidos.Dock = DockStyle.Fill;
            panelCentro.Controls.Add(frmPedidos);
            frmPedidos.Show();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            panelCentro.Controls.Clear();
            frmConfig frmConfig = new frmConfig();
            frmConfig.TopLevel = false;
            frmConfig.FormBorderStyle = FormBorderStyle.None;
            frmConfig.Dock = DockStyle.Fill;
            panelCentro.Controls.Add(frmConfig);
            frmConfig.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelCentro.Controls.Clear();
            frmCarrossel frmCarrossel = new frmCarrossel();
            frmCarrossel.TopLevel = false;
            frmCarrossel.FormBorderStyle = FormBorderStyle.None;
            frmCarrossel.Dock = DockStyle.Fill;
            panelCentro.Controls.Add(frmCarrossel);
            frmCarrossel.Show();
        }

        private void panelCentro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


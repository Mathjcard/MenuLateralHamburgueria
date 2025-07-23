using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace MenulateralHamburgueria
{
    public partial class frmCarrossel : Form
    {
        // Lista com as imagens do carrossel
        private Image[] imagensCarrossel;
        private int indiceAtual = 0;
        private Timer timerTroca; // Timer para trocar as imagens
        private Timer timerFade;  // Timer para fazer o efeito de fade
        private float opacidade = 1.0f; // controle do fade
        private bool fadeOut = true;    // controle para saber se está sumindo ou aparecendo

        public frmCarrossel()
        {
            InitializeComponent();
            this.Load += frmCarrossel_Load; // Garante que o método de Load seja chamado
        }

        private void frmCarrossel_Load(object sender, EventArgs e)
        {
            // Carregar todas as imagens de uma vez na memória
            imagensCarrossel = new Image[]
            {
                Image.FromFile(Application.StartupPath + @"\Imagens\1.png"),
                Image.FromFile(Application.StartupPath + @"\Imagens\2.png"),
                Image.FromFile(Application.StartupPath + @"\Imagens\3.png"),
                Image.FromFile(Application.StartupPath + @"\Imagens\4.png"),
                Image.FromFile(Application.StartupPath + @"\Imagens\5.png")

            };

            // Configura o PictureBox
            picCarrossel.Dock = DockStyle.Fill;
            picCarrossel.SizeMode = PictureBoxSizeMode.Zoom;
            picCarrossel.Image = imagensCarrossel[indiceAtual];

            // Timer para troca de imagem (a cada 3 segundos)
            timerTroca = new Timer();
            timerTroca.Interval = 3000;
            timerTroca.Tick += TimerCarrossel_Tick;
            timerTroca.Start();

            // Timer para efeito de fade
            timerFade = new Timer();
            timerFade.Interval = 20; // quanto menor, mais suave fica o fade
            timerFade.Tick += TimerFade_Tick;
        }

        private void frmCarrossel_Resize(object sender, EventArgs e)
        {
            // Faz o PictureBox acompanhar o tamanho do formulário
            picCarrossel.Width = this.ClientSize.Width;
            picCarrossel.Height = this.ClientSize.Height;
        }

        private void TimerCarrossel_Tick(object sender, EventArgs e)
        {
            // Inicia o efeito fade
            fadeOut = true;
            opacidade = 1.0f;
            timerFade.Start();
        }

        private void TimerFade_Tick(object sender, EventArgs e)
        {
            // Efeito Fade Out (escurecendo)
            if (fadeOut)
            {
                opacidade -= 0.1f;
                if (opacidade <= 0)
                {
                    // Troca a imagem quando a opacidade chegar a 0
                    indiceAtual = (indiceAtual + 1) % imagensCarrossel.Length;
                    picCarrossel.Image = imagensCarrossel[indiceAtual];

                    fadeOut = false; // começa o Fade In
                }
            }
            else // Efeito Fade In (clareando)
            {
                opacidade += 0.1f;
                if (opacidade >= 1.0f)
                {
                    opacidade = 1.0f;
                    timerFade.Stop(); // encerra o fade
                }
            }

            // Aplica o nível de opacidade à imagem (via Overlay)
            picCarrossel.Image = AjustarOpacidade(imagensCarrossel[indiceAtual], opacidade);
        }

        // Função que ajusta a opacidade de uma imagem
        private Image AjustarOpacidade(Image img, float opacidade)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacidade; // aplica a opacidade

                ImageAttributes atributos = new ImageAttributes();
                atributos.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, atributos);
            }
            return bmp;
        }
    }
}

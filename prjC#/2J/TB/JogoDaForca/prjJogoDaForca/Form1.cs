using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoDaForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Lista de palavras para sorteio no jogo da Forca.

        List<string> lista = new List<string>();
        List<string> dicas = new List<string>();
        

        //Inicio do codiogo para o Jogo.

        Forca jogo;
        Label[] Letras;
        
        int Erro = 0;
        SoundPlayer som;

        private void Form1_Load(object sender, EventArgs e)
        {
            CarreagrLista();
            jogo  = new Forca(lista);
            jogo.Sortear();
            DesenharPalavra(jogo.DevolverPalavra());
            som = new SoundPlayer();
            som.SoundLocation = Environment.CurrentDirectory + "\\fundo.wav";
            som.PlayLooping();
            lbDica.Text = "DICA:" + dicas[jogo.Pos];
        }

        private void CarreagrLista()
        {
            string file = Environment.CurrentDirectory + "\\lista.txt";
            StreamReader st = new StreamReader(file, Encoding.UTF8);
            int qtd = File.ReadAllLines(file).Count();
            for (int i = 0; i < qtd; i++)
            {
                string linha = st.ReadLine();
                string[] campo = linha.Split(',');
                lista.Add(campo[0]);
                dicas.Add(campo[1]);
            }
            st.Close();
        }

        //Box para as letras.

        private void DesenharPalavra(string p)
        {
            int qtd = p.Length;
            Letras = new Label[qtd];
            int cx = 10;
            int cy = 10;
            for (int i = 0; i < qtd; i++)
            {
                Letras[i] = new Label();
                Letras[i].Text = "?";
                Letras[i].AutoSize = false;
                Letras[i].Width = 30;
                Letras[i].Height = 30;
                Letras[i].BorderStyle = BorderStyle.FixedSingle;
                Letras[i].ForeColor = Color.Black;
                Letras[i].BackColor = Color.White;
                Letras[i].TextAlign = ContentAlignment.MiddleCenter;
                if (i % 15 == 0 && i != 0)
                {
                    cy += 35;
                    cx = 10;
                }
                Letras[i].Top = cy;
                Letras[i].Left = cx;
                cx += 35;
                pnPalavra.Controls.Add(Letras[i]);
                Letras[i].Show();
            }
        }

        //Ação do botão ao clicar, e codigo para que ao clicar no botão a letra seja direcionada até a box onde se encontra a letra.

         private void btnJogar_Click(object sender, EventArgs e)
         {
            DesenharLetra(txtLetra.Text);
            txtLetra.Focus();
            txtLetra.SelectAll();
         }


         private void DesenharLetra(string letra)
         {
             string p = jogo.DevolverPalavra();
             bool achei = false;
             if (lbLetras.Text.Contains(letra))
             {
                 MessageBox.Show("Letra já digitada");
                 return;
             }
             lbLetras.Text += letra + "  ";

             for (int i = 0; i < p.Length; i++)
             {
                 if (p.Substring(i, 1).Equals(letra))
                 {
                     Letras[i].Text = letra;
                     achei = true;
                 }
             }

             if (achei == false)
             {
                 Erro++;
                 DesenharBoneco();
             }
             
             if (Erro == 6)
             {
                 timer1.Stop();
                 Derrota();
                 lbCronometro.Text = "120";
                 timer1.Start();
             }

             vitoria();

         }

         private void vitoria()
         {
             string p = jogo.DevolverPalavra();
             string tmp = "";
             foreach (Label letra in Letras)
             {
                 tmp += letra.Text;
             }
             if (p.Equals(tmp))
             {
                 MessageBox.Show("Voce é uma LENDA!!!");
                 NovoJogo();
                 lbCronometro.Text = "120";
                 timer1.Start();
                 NovoJogo();
             }
         }

        //Código onde diz que você perdeu.

         private void Derrota()
         {
             MessageBox.Show("Você perdeu. A palavra era " + jogo.DevolverPalavra());
             NovoJogo();
         }

        //Código onde o Jogo reinicia.

         private void NovoJogo()
         {
             Erro = 0;
             pnPalavra.Controls.Clear();
             pbBoneco.Image = null;
             jogo.Sortear();
             DesenharPalavra(jogo.DevolverPalavra());
             lbLetras.Text = "";
             lbDica.Text = "DICA:" + dicas[jogo.Pos];
         }

         private void DesenharBoneco()
         {
             //Codigo para fazer a busca de arquivos em pastas;

             string arquivo = Environment.CurrentDirectory + "\\imagens\\forca" + Erro + ".png";
             pbBoneco.Image = Image.FromFile(arquivo);

         }

         private void timer1_Tick(object sender, EventArgs e)
         {
             int seg = Int16.Parse(lbCronometro.Text);
             seg--;
             lbCronometro.Text = seg.ToString();
             if (seg <= 15)
             {
                 Console.Beep();
                 lbCronometro.ForeColor = Color.Red;
             }
             if (seg <= 0)
             {
                 timer1.Stop();
                 Derrota();
                 lbCronometro.Text = "120";
                 lbCronometro.ForeColor = Color.Gold;
                 timer1.Start();

             }
         }


    }
}

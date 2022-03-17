using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        List<string> lista = new List<string>()
        {
            "SANTOS","FREEFIRE","HEXALAB","DESIGNER","DIARIO","GAGO",
            "MATHEUS","KAH","SAO PAULO","MAXIMOS","DEVELOPER","BACKEND",
            "FRONTEND","COLEGIO","HERCULES","ANHANGUERA","AMAZONCRIPZ","COLMEIA",
            "JOGADOR","MUNDIAL","RUSSIA","UCRANIA","COVID","BONDINHO","DATENA","PERCIVAL",
            "BOLSOMINION","LULA"
        };
        Forca jogo;
        Label[] Letras;

        private void Form1_Load(object sender, EventArgs e)
        {
            jogo  = new Forca(lista);
            jogo.Sortear();
            DesenharPalavra(jogo.DevolverPalavra());
        }

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
                Letras[i].ForeColor = Color.Blue;
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
    }
}

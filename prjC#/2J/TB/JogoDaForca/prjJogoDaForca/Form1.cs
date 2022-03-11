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

        private void Form1_Load(object sender, EventArgs e)
        {
            jogo  = new Forca(lista);
            jogo.Sortear();
            MessageBox.Show(jogo.DevolverPalavra());



        }
    }
}

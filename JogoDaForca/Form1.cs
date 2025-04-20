using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        private JogoForca jogo;
        static List<Label> labels = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            labels.AddRange(new[] { label0, label1, label2, label3, label4, label5, label6, label7, label8, label9 });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jogo = new JogoForca();

            lblChaveSort.Text = jogo.GetCategoria();
            lblTeste3.Text = jogo.GetPalavra(); // Remover depois (é "debug")

            AtualizarInterface();
        }

        private void AtualizarInterface()
        {
            int tamanho = jogo.GetTamanho();

            for (int i = 0; i < labels.Count; i++)
            {
                if (i < tamanho)
                {
                    labels[i].Visible = true;
                    labels[i].Text = jogo.LetraEstaRevelada(i) ? jogo.GetLetra(i).ToString() : "_";
                }
                else
                {
                    labels[i].Visible = false;
                }
            }
        }

        private void letra_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            char letra = botao.Text.ToLower()[0];

            jogo.VerificarLetra(letra);
            AtualizarInterface();
            botao.Enabled = false;
        }
    }

}

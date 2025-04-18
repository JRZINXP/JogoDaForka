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
        static Label[] labels = new Label[10];
        public Form1()
        {
            InitializeComponent();
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            labels[6] = label7;
            labels[7] = label8;
            labels[8] = label9;
            labels[9] = label10;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniciar();
            main.lista();//Inicializar a lista para poder gerar a chave
            lblChaveSort.Text = main.chave();
        }

        
        public void iniciar()
        {
            int tamanho = main.tamanho();
            if (tamanho == 4) { 
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            else if (tamanho == 5){
                label1.Visible = false;
                label2.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            else if (tamanho == 6)
            {
                label1.Visible = false;
                label2.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            else if (tamanho == 7)
            {
                label1.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            else if (tamanho == 8)
            {
                label1.Visible = false;
                label10.Visible = false;
            }
            else if (tamanho == 9)
            {
                label10.Visible = false;
            }
        }
    }
}

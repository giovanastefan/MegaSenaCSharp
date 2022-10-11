using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostaMegaSena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFazerAposta_Click(object sender, EventArgs e)
        {
            MegaSena megaSena = new MegaSena();
            int[] aposta = new int[10];
            int i = 0;
            Boolean error = false;

            foreach (string j in txtAposta.Text.Split(' '))
            {
                if (!aposta.Contains(int.Parse(j)))
                {
                    aposta[i] = int.Parse(j);
                    i++;
                }

                if(i == 10)
                {
                    lblError.Text = "Só são considerados os dez primeiros números!";
                    break;
                }
            }

            foreach (int l in aposta)
            {
                if(l > 60 || l<0)
                {
                    error = true;
                }
            }

            if (!error)
            {
                megaSena.leAposta(aposta);

                foreach (int j in aposta)
                {
                    lblAposta.Text = lblAposta.Text + " " + j.ToString();
                }

                foreach (int k in megaSena.apuraResultado())
                {
                    txtResultado.Text = txtResultado.Text + " " + k.ToString();
                }

                lblPontos.Text = megaSena.pontosFinais().ToString() + " pontos!";

            }
            else
            {
                MessageBox.Show("Lembre-se os números devem ser entre 1 e 60!!", "Error!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAposta.Clear();
            txtResultado.Clear();
            lblAposta.Text = "Aposta: ";
            lblPontos.Text = "0 pontos!";
        }
    }
}

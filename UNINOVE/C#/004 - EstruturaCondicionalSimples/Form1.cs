using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004___EstruturaCondicionalSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMedia_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNota1.Text);
            double n2 = Convert.ToDouble(txtNota2.Text);
            double n3 = Convert.ToDouble(txtNota3.Text);
            double n4 = Convert.ToDouble(txtNota4.Text);
            double media = (n1 + n2 + n3 + n4) / 4;

            lblMediaReturn.Text = media.ToString();
            /*
               if (media >= 7)
               {
                  lblSituacaoReturn.Text = "APROVADO!";   
               }
               else
               {
                   lblSituacaoReturn.Text = "REPROVADO";
               } 
            */
            _ = media >= 7 ? lblSituacaoReturn.Text = "APROVADO" : lblSituacaoReturn.Text = "REPROVADO";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

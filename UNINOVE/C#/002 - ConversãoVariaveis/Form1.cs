using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002___ConversãoVariaveis
{
    public partial class FormSoma : Form
    {
        public FormSoma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtValorA_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInteiro_Click(object sender, EventArgs e)
        {
            //Declarando variáveis ============

            int a, b, soma;

            a = Int32.Parse(txtValorA.Text);
            b = Int32.Parse(txtValorB.Text);

            //Processamento ============

            soma = a + b;

            //Saída de Dados

            txtResultado.Text = soma.ToString();
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = double.Parse(txtValorB.Text);

            double soma = a + b;

            txtResultado.Text = soma.ToString();

        }
    }
}

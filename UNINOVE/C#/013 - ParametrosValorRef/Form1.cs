using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013___ParametrosValorRef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void porValor(double varA, double varB)
        {
            varA *= 2;
            varB *= 5;

        }

        void porReferencia(ref double varA, ref double varB)
        {
            varA *= 2;
            varB *= 5;
        }
        void limpar()
        {
            txtResA.Clear();
            txtResB.Clear();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtVarA.Text);
            double num2 = Convert.ToDouble(txtVarB.Text);

            porValor(num1, num2);

            limpar();

            txtResA.Text = num1.ToString();
            txtResB.Text = num2.ToString();
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtVarA.Text);
            double num2 = Convert.ToDouble(txtVarB.Text);

            porReferencia(ref num1, ref num2);

            limpar();

            txtResA.Text = num1.ToString();
            txtResB.Text = num2.ToString();
        }
    }
}

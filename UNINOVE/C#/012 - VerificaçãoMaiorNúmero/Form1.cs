using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012___VerificaçãoMaiorNúmero
{ 
    public partial class Form1 : Form
    {
         string verificaMaior(int num1, int num2)
        {
            
            if(num1 == num2)
            {
                return "Números iguais";
            } 
            else if(num1 > num2)
            {
                return num1.ToString();
            }
            else
            {
                return num2.ToString();
            }
        }

        void limparConteudo()
        {
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparConteudo();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtA.Text);
            int num2 = Convert.ToInt32(txtB.Text);
            txtMaior.Text = verificaMaior(num1, num2);
        }
    }
}

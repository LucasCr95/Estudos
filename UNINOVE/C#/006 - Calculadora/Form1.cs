using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006___Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroConjunto.Clear();
            txtSegundoConjunto.Clear();
            txtResultado.Clear();
            txtPrimeiroConjunto.Focus();
        }

        private void rdSomar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double primeiro, segundo, total;

            if (double.TryParse(txtPrimeiroConjunto.Text, out primeiro) == false)
            {
                MessageBox.Show("Valores inválidos", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrimeiroConjunto.Clear();
                txtPrimeiroConjunto.Focus();

                return;
            }
            //          Verifica se o que foi digitado é numero e se está vazio
            if (double.TryParse(txtSegundoConjunto.Text, out segundo) == false)
            {
                MessageBox.Show("Valores inválidos", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtSegundoConjunto.Clear();
                txtSegundoConjunto.Focus();
                return;
            }

            if (rdSomar.Checked == true)
            {
                total = primeiro + segundo;
            }
            else if (rdSubtrai.Checked == true)
            {
                total = primeiro - segundo;
            }
            else if (rdMultiplica.Checked == true)
            {
                total = primeiro * segundo;
            }
            else
            {
                if (segundo == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero", "Calculadora", MessageBoxButtons.OK);
                    return;
                }
                total = primeiro / segundo;
            }

            txtResultado.Text = total.ToString();
        }
    }
}

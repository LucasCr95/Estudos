using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011___EstruturaRepetiçãoIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numX = Convert.ToInt32(txtValorX.Text);
            int numY = Convert.ToInt32(txtValorY.Text);
            int resultado = 0;

            for(int i = 0; numX <= numY; numX++)
            {
                if(numX % 2 == 0)
                {
                    resultado += numX;
                }

            }
            lblResultado.Text = "Soma dos pares: " + resultado.ToString();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int numX = Convert.ToInt32(txtValorX.Text);
            int numY = Convert.ToInt32(txtValorY.Text);
            ltbLista.Items.Clear();

            for(int i = 0; numX <= numY; numX++)
            {
                if(numX % 2 == 0)
                {
                    ltbLista.Items.Add(numX);
                }
            }
        }
    }
}

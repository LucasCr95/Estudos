using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009___EstruturasDeRepetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lboxNumeros.Items.Clear();

            for(int i = 1; i <= 100; i++)
            {
                lboxNumeros.Items.Add(i * 10);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboxNumeros.Items.Clear();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lboxNumeros.Items.Clear();

            int i = 1;

            while(i <= 100)
            {
                lboxNumeros.Items.Add(i * 10);
                i++;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lboxNumeros.Items.Clear();

            int i = 1;

            do
            {
                lboxNumeros.Items.Add(i * 10);
                i++;
            } while (i <= +100);
        }
    }
}

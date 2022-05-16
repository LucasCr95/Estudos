using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003___IncrementoDecremento
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

        private void btbPre_Click(object sender, EventArgs e)
        {
            int x, y;

            x = Convert.ToInt32(txtNum.Text);
            y = ++x;

            MessageBox.Show("Y = " + y + " X = " + x, "Incremento Pré-Fixado");

        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(txtNum.Text);
            y = x++;

            MessageBox.Show("Y = " + y + " X = " + x, "Incremento Pós-Fixado");
        }
    }
}

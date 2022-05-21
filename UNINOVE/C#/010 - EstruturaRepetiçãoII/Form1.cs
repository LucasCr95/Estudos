using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010___EstruturaRepetiçãoII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarPares_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();
            int firstNum = Convert.ToInt32(txtFirstNum.Text);
            int secondNum = Convert.ToInt32(txtSecondNum.Text);
            
            for(int i = 0; firstNum <= secondNum; firstNum++)
            {
                if(firstNum % 2 == 0)
                {
                    listBoxNumeros.Items.Add(firstNum);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();
        }

        private void brnImpar_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();

            int firstNum = Convert.ToInt32(txtFirstNum.Text);
            int secondNum = Convert.ToInt32(txtSecondNum.Text);

            for(int i = 0; firstNum <= secondNum; firstNum++)
            {
                if(!(firstNum % 2 == 0))
                {
                    listBoxNumeros.Items.Add(firstNum);
                }
            }
        }
    }
}

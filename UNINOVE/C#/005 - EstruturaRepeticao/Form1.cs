using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005___EstruturaRepeticao
{
    public partial class Seleciona : Form
    {
        public Seleciona()
        {
            InitializeComponent();
        }

        private void btnVerDia_Click(object sender, EventArgs e)
        {
            decimal diaSemana = diaSemanaValue.Value;

            switch (diaSemana)
            {
                case 1:
                    lblTxtDiaSemanaReturn.Text = "Segunda";
                    break;
                case 2:
                    lblTxtDiaSemanaReturn.Text = "Terça";
                    break;
                case 3:
                    lblTxtDiaSemanaReturn.Text = "Quarta";
                    break;
                case 4:
                    lblTxtDiaSemanaReturn.Text = "Quinta";
                    break;
                case 5:
                    lblTxtDiaSemanaReturn.Text = "Sexta";
                    break;
                case 6:
                    lblTxtDiaSemanaReturn.Text = "Sábado";
                    break;
                default:
                    lblTxtDiaSemanaReturn.Text = "Domingo";
                    break;

            }
             
        }

        private void Seleciona_Load(object sender, EventArgs e)
        {
            diaSemanaValue.ResetText();
        }

        private void lblDiaSemanaReturn_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

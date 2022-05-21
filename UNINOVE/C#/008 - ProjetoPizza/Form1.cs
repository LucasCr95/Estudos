using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008___ProjetoPizza
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void cboSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboSabores.SelectedIndex = 0;
            cboSabores.Focus();

            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            rdbSemBorda.Checked = true;

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string strSabor = cboSabores.Text;
            string strPedido = null;

            if (string.IsNullOrEmpty(cboSabores.Text))
            {
                MessageBox.Show("Selecione um sabor", "Selecione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabores.Focus();
                return;
            }

            strPedido = strSabor;

            if (chkAzeitona.Checked)
            {
                strPedido += ", azeitonas";
            }
            if (chkCebola.Checked)
            {
                strPedido += ", cebola";
            }

            if (rdbComBorda.Checked)
            {
                strPedido += " e borda recheada.";
            }
            else
            {
                strPedido += " sem borda recheada.";
            }

            MessageBox.Show(strPedido, "Confirmar pedido...", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Pizza_Load(object sender, EventArgs e)
        {
            cboSabores.Items.Add("Baiana");
            cboSabores.Items.Add("Brócolis");
            cboSabores.Items.Add("Calabresa");
            cboSabores.Items.Add("Frango c/ Catupiry");
            cboSabores.Items.Add("Frango c/ Milho");
            cboSabores.Items.Add("Mussarela");
            cboSabores.Items.Add("Portuguesa");
            cboSabores.Items.Add("Toscana");
        }
    }
}

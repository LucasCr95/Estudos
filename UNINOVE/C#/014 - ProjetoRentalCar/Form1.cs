using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Inclui o namespace para o banco
using System.Data.SqlClient;


namespace _014___ProjetoRentalCar
{
    public partial class formRentalCar : Form
    {
        public formRentalCar()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria um novo formulário
            Form frm = new frmCadastroCliente();

            //Define que é o pai dessa janela
            frm.MdiParent = this;

            //Exibe o formulário
            frm.Show();
        }

        private void formRentalCar_Load(object sender, EventArgs e)
        {

        }
    }
}

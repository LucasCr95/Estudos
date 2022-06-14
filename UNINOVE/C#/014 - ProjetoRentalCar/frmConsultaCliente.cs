using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace para SQL Server
using System.Data.SqlClient;

namespace _014___ProjetoRentalCar
{
    public partial class frmConsultaCliente : Form
    {
        //Declara uma variável(objeto) do tipo frmCadastroCliente
        frmCadastroCliente frmCliente;

        //Passando por parâmetro o form frmCadastroCliente
        //Construtor receve como parâmtro declara uma variável (objeto) do tipo frmCadastroCliente

        public frmConsultaCliente(frmCadastroCliente frmCliente)
        {
            //Variável da classe = parâmetro do construtor
            this.frmCliente = frmCliente;

            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            string sqlQuery;

            SqlConnection conCliente = Conexao.getConnection();

            sqlQuery = "SELECT id_cliente, nome, cpf, dt_nasc FROM cliente ORDER BY nome";

            // Declara um DataAdapter
            SqlDataAdapter dta = new SqlDataAdapter(sqlQuery, conCliente);

            //Declara um DataTable
            DataTable dt = new DataTable();

            try
            {
                dta.Fill(dt);

                //Configura a fonte de dados no DataGridView
                dgvCliente.DataSource = dt;

                dgvCliente.RowsDefaultCellStyle.BackColor = Color.White;

                dgvCliente.Columns[0].HeaderCell.Value = "Código do Cliente";
                dgvCliente.Columns[1].HeaderCell.Value = "Nome";
                dgvCliente.Columns[2].HeaderCell.Value = "CPF";
                dgvCliente.Columns[3].HeaderCell.Value = "Dt.Nasc";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema ao listar cadastro" + ex, "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if(conCliente != null)
                {
                    conCliente.Close();
                }
            }

        }
    }
}

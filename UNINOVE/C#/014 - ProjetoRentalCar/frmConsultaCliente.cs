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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // Variável armazena código cliente no DataGridView
            string codigoCliente;

            // Seleciona código da linha atual da coluna [0] do DataGridView
            codigoCliente = dgvCliente.CurrentRow.Cells[0].Value.ToString();

            string sqlQuery;

            SqlConnection conClienteConsulta = Conexao.getConnection();

            SqlDataReader dtr = null;

            sqlQuery = "SELECT id_cliente, nome, cpf, dt_nasc FROM cliente WHERE id_cliente = @id_cliente";

            try
            {
                conClienteConsulta.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conClienteConsulta);

                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(codigoCliente)));

                dtr = cmd.ExecuteReader();

                // Se retornou registro, preenche a tela do frmCadastroCliente
                if (dtr.Read())
                {
                    frmCliente.txtCodigo.Text = dtr["ID_CLIENTE"].ToString();
                    frmCliente.txtNome.Text = dtr["NOME"].ToString();
                    frmCliente.mskTxtNasc.Text = dtr["DT_NASC"].ToString();
                    frmCliente.mksTxtCPF.Text = dtr["CPF"].ToString();
                }
            }
            catch(Exception ex)
            {
                // Exibe a mensagem da execeção
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(dtr != null)
                {
                    dtr.Close();
                }
                if(conClienteConsulta != null)
                {
                    conClienteConsulta.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

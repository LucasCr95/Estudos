using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Inclui namaspace para banco SQLServer
using System.Data.SqlClient;

namespace _014___ProjetoRentalCar
{
    public partial class frmCadastroCliente : Form
    {
        internal readonly object mskNasc;
        internal object mskCPF;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void habilitar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            mskTxtCPF.Enabled = true;
            mskTxtNasc.Enabled = true;

        }

        private void desabilitar()
        {
            //txtCodigo sempre será desabilitado
            txtCodigo.Enabled = false;

            txtNome.Enabled = false;
            mskTxtCPF.Enabled = false;
            mskTxtNasc.Enabled = false;
        }

        private void limparControles()
        {
            txtCodigo.Enabled = false;

            txtNome.Clear();
            txtCodigo.Clear();
            mskTxtCPF.Clear();
            mskTxtNasc.Clear();

            mskTxtCPF.Focus();
        }

        //Função para validar os campos de entrada.
        private bool validaDados()
        {
            // Verifica se o CPF está preenchido
            if (string.IsNullOrEmpty(mskTxtCPF.Text)){
                MessageBox.Show("Preenchimento obrigatório", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mskTxtCPF.Clear();
                mskTxtCPF.Focus();

                return false;
            }

            // Variável auxiliar
            DateTime auxData;
            if(!(DateTime.TryParse(mskTxtNasc.Text, out auxData)))
            {
                MessageBox.Show("Preenchimento obrigatório", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mskTxtNasc.Clear();
                mskTxtNasc.Focus();

                return false;
            }

            // Verifica se o nome foi preenchido
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preenchimento obrigatório", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtNome.Focus();

                return false;
            }

            return true;
        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            habilitar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                // txtCodigo não vazio, já foi feito outra consulta

                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um novo registro?", "Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    limparControles();
                return;
            }

            if(validaDados() == false)
            {
                return;
            }

            // Declaraão para guardar as instruções SQL
            string sqlQuery;

            // Cria conexão chamado o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            sqlQuery = "INSERT INTO cliente(nome, dt_nasc, cpf) VALUES(@nome, @dt_nasc, @cpf)";

            // Tratamento de exceções
            try
            {
                // Abre a conexão com o banco
                conCliente.Open();

                // Cria um objeto do tipo SqlCommand com a instrução SQL e a conexão
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                // Define, adiciona parâmetros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@dt_nasc", Convert.ToDateTime(mskTxtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskTxtCPF.Text));

                // ExecuteNonQuery envia instruções para o banco que estão em cmd
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso!", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Limpa os campos para nova entrada de dados
                limparControles();
            }
            // Se houve alfuma exceção dentro do bloco try
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível concluir o cadastro" + ex, "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Se houve ou não exceções, o bloco try é sempre executado
            finally
            {
                if(conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Verifica se tem o código do Cliente no txtCodigo
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Para alterar, clique em Consultar", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Valida os dados
            if (validaDados() == false)
            {
                return;
            }

            // Declaração para guardar as instruções SQL
            string sqlQuery;

            //Cria conexão
            SqlConnection conCliente = Conexao.getConnection();

            sqlQuery = "UPDATE cliente set nome=@nome, dt_nasc=@dt_nasc, cpf=@cpd WHERE id_cliente=@id_cliente";

            // Tratamento de exceções
            try
            {
                conCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                // Define os parâmetros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@dt_nasc", Convert.ToDateTime(mskTxtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskTxtCPF.Text));
                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                // Executa o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro alterado com sucesso", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparControles();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Problema ao alterar cadastro" + ex, "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if(conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o número de cadastro que deseja excluir", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmação de exclusão
            if (MessageBox.Show("Deseja excluir permanentemente o cadastro?", "Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                SqlConnection conCliente = Conexao.getConnection();

                sqlQuery = "DELETE FROM cliente WHERE id_cliente=@id_cliente";

                try
                {
                    conCliente.Open();

                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro excluído com sucesso!", "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparControles();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Problemas ao excluir cadastro" + ex, "Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Cria o formulário, passando como parâmetro a referência do mesmo
            Form frm = new frmConsultaCliente(this);

            //Define o pai dessa janela
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}

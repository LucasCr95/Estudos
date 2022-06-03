using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Definições dos namespace usado no projeto para o SQL Server
using System.Data;
using System.Data.SqlClient;

namespace _014___ProjetoRentalCar
{
    public class Conexao
    {
        //método para relizar a conexão com o DB
        public static SqlConnection getConnection()
        {
            //cria um objeto do tipo SqlConennection e configura a string de conexão

            //Adicionando o sinal de @ antes das aspas dupla
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-V03RTFN\DB_SQLCR;Initial Catalog=DB_RENTALCAR;Integrated Security=True;Pooling=False");
            return cnn;
        }
    }
}

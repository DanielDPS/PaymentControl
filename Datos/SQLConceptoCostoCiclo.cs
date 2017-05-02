using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class SQLConceptoCostoCiclo:IConceptoCostoCiclo
    {
        private SqlCommand comando;
        public int ObtenerIdConceptoCostoCiclo(int fkconcepto, int fkcosto, int fkciclo)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                comando = new SqlCommand("paObtenerIdConceptoCostoCiclo", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idout", SqlDbType.Int).Direction = ParameterDirection.Output;
                comando.Parameters.Add("@fkconcepto", SqlDbType.Int).Value = fkconcepto;
                comando.Parameters.Add("@fkcosto", SqlDbType.Int).Value = fkcosto;
                comando.Parameters.Add("@fkciclo", SqlDbType.Int).Value = fkciclo;
                conexion.Open();
                comando.ExecuteNonQuery();
                int idout = (int)comando.Parameters["@idout"].Value;
                return idout;

            }
        }
    }
}

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
    public class SQLGrupoAlumnoTC:IGrupoAlumnoTCRepositorio
    {
        private SqlCommand Comando;
        public int ObtenerIdIndiceGrupoAlumnoTC(int fkgrupo, int fkalumno, int fkturno, int fkciclo)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerIdGrupoAlumnoTC", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idindice", SqlDbType.Int).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("@fkgrupo", SqlDbType.Int).Value = fkgrupo;
                Comando.Parameters.Add("@fkalumno", SqlDbType.Int).Value = fkalumno;
                Comando.Parameters.Add("@fkturno", SqlDbType.Int).Value = fkturno;
                Comando.Parameters.Add("@fkciclo", SqlDbType.Int).Value = fkciclo;
                conexion.Open();
                Comando.ExecuteNonQuery();
                int id = (int)Comando.Parameters["@idindice"].Value;
                return id;


            }
        }
    }
}

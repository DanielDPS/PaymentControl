using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelos;
namespace Datos
{
    public class SQLSemestreRepositorio:ISemestreRepositorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;
        public Semestre ObtenerSemestrePorId(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerSemestrePorId", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fkciclo", SqlDbType.Int).Value = id;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                Semestre semestre = null;
                while (Leer.Read())
                {
                    semestre = new Semestre();
                    semestre.Id = (int)Leer["Id"];
                    semestre.Nombre = (string)Leer["Nombre"];
                }
                return semestre;
            }
        }
    }
}

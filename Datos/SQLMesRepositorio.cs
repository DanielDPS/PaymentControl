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
    public class SQLMesRepositorio:IMesReporitorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;
        public IEnumerable<Mes> ObtenerMesesPorFkCiclo(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerMesesPorFkciclo", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fkciclo", SqlDbType.Int).Value = id;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Mes> meses = new List<Mes>();
                while (Leer.Read())
                {
                    Mes mes = new Mes();
                    mes.Id = (int)Leer["Id"];
                    mes.Nombre = (string)Leer["Mes"];
                    meses.Add(mes);
                }
                return meses;

            }
        }
    }
}

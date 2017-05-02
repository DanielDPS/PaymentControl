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
   public class SQLCicloFechaRepositorio:ICicloFechaRepositorio
    {
       private SqlCommand Comando;
       private SqlDataReader Leer;
        public FCiclo ObtenerCicloFechaPorId(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerCicloFechaPorId", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idciclof", SqlDbType.Int).Value = id;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                FCiclo ciclof = null;
                while (Leer.Read())
                {
                    ciclof = new FCiclo();
                    ciclof.Id = (int)Leer["Id"];
                    ciclof.Inicio = (DateTime)Leer["Inicio"];
                    ciclof.Fin = (DateTime)Leer["Fin"];
                    ciclof.Fkciclo = (int)Leer["Fk_Ciclo"];
                    
                }
                return ciclof;
            }
        }
        public IEnumerable<FCiclo> ObtenerCicloFechaPorFkAlumno(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerCiclosFechaPorFkAlumno", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fkalumno", SqlDbType.Int).Value = id;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<FCiclo> ciclosFecha = new List<FCiclo>();
                while (Leer.Read())
                {
                    FCiclo cicloFecha = new FCiclo();
                    cicloFecha.Id = (int)Leer["Id"];
                    cicloFecha.Inicio = (DateTime)Leer["Inicio"];
                    cicloFecha.Fin = (DateTime)Leer["Fin"];
                    cicloFecha.Fkciclo = (int)Leer["Fk_Ciclo"];
                    ciclosFecha.Add(cicloFecha);             
                }
                return ciclosFecha;
            }
        }
    }
}

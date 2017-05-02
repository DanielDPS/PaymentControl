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
   public class SQLTurnoRepositorio:ITurnoRepositorio
    {
       private SqlCommand Comando;
       private SqlDataReader Leer;
        public IEnumerable<Turno> ObtenerTurnos()
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerTodosTurno", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Turno> turnos = new List<Turno>();
                while (Leer.Read())
                {
                    Turno turno = new Turno();
                    turno.Id = (int)Leer["Id"];
                    turno.Nombre = (string)Leer["Nombre"];
                    turnos.Add(turno);
                }
                return turnos;
            }
        }
    }
}

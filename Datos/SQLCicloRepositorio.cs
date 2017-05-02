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
   public  class SQLCicloRepositorio:ICicloRepositorio
    {
       private SqlCommand Comando;
       private SqlDataReader Leer;
        public Ciclo ObtenerCicloPorId(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerCicloPorId", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idciclo", SqlDbType.Int).Value = id;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                Ciclo ciclo = null;
                while (Leer.Read())
                {
                    ciclo = new Ciclo();
                    ciclo.Id = (int)Leer["Id"];
                    ciclo.Año = (int)Leer["Año"];
                    ciclo.Fksemestre = (int)Leer["Fk_Semestre"];
                    ciclo.Nombre = (string)Leer["Nombre"];
                    
                }
                return ciclo;
            }
        }




        public List<Ciclo> ObtenerCiclos()
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerCiclos", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                Leer=Comando.ExecuteReader();
                List<Ciclo> cilos = new List<Ciclo>();
                while (Leer.Read())
                {
                    Ciclo ciclo = new Ciclo();
                    ciclo.Id = (int)Leer["Id"];
                    ciclo.Año = (int)Leer["Año"];
                    ciclo.Fksemestre = (int)Leer["Fk_Semestre"];
                    ciclo.Nombre = (string)Leer["Nombre"];
                    ciclo.Periodo = (string)Leer["Ciclo"];
                    cilos.Add(ciclo);
                }
                return cilos;

            }
           
        }
    }
}

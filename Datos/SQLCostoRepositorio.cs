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
    public class SQLCostoRepositorio:ICostoRepositorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;
        public IEnumerable<Costo> ObtenerCostos(int fkconcepto)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerCostosPorIdConcepto", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fkconcepto", SqlDbType.Int).Value = fkconcepto;
                conexion.Open();            
                Leer = Comando.ExecuteReader();
                List<Costo> costos = new List<Costo>();
                while (Leer.Read())
                {
                    Costo costo = new Costo();
                    costo.Id = (int)Leer["Id"];
                    costo.Precio = (int)Leer["Costo"];
                    costos.Add(costo);
                    
                }
                return costos;

            }
        }
    }
}

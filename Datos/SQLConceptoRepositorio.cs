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
    public class SQLConceptoRepositorio:IConceptoRepositorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;

        public IEnumerable<Concepto> ObtenerConceptos()
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerConceptos", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Concepto> conceptos = new List<Concepto>();
                while (Leer.Read())
                {
                    Concepto concepto = new Concepto();
                    concepto.Id = (int)Leer["Id"];
                    concepto.Nombre = (string)Leer["Concepto"];
                    conceptos.Add(concepto);
                    
                }
                return conceptos;

            }
        }


        public IEnumerable<Concepto> ObtenerConceptosPorFkAlumno(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerConceptosPorFkAlumno", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fkalumno", SqlDbType.Int).Value = id;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Concepto> conceptos = new List<Concepto>();
                while (Leer.Read())
                {
                    Concepto concepto = new Concepto();
                    concepto.Id = (int)Leer["Id"];
                    concepto.Nombre = (string)Leer["Concepto"];
                    conceptos.Add(concepto);
                    
                }
                return conceptos;
            }
        }


        public Concepto ObtenerConcepto(int fkciclo)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerConceptoPorCiclo", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fkciclo", SqlDbType.Int).Value = fkciclo;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                Concepto concepto = null;
                while (Leer.Read())
                {
                     concepto = new Concepto();
                    concepto.Id = (int)Leer["Id"];
                    concepto.Nombre = (string)Leer["Concepto"];
                    
                }
                return concepto;
            }
        }
    }
}

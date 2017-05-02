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
    public class SQLGrupoRepositorio:IGrupoRepositorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;

        public IEnumerable<Grupo> ObtenerTodoslosGrupos(int fkciclo)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerGrupos", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@fkciclo", SqlDbType.Int).Value = fkciclo;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Grupo> grupos = new List<Grupo>();
                while (Leer.Read())
                {
                    Grupo grupo = new Grupo();
                    grupo.Id = (int)Leer["Id"];
                    grupo.Nombre = (int)Leer["Nombre"];
                    grupos.Add(grupo);

                }
                return grupos;

            }
        }
    }
}

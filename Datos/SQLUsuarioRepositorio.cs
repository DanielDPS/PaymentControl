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
    public class SQLUsuarioRepositorio:IUsuarioRepositorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;


        public Usuario ObtenerUsuarioPorUsuarioyContra(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paInicioSesion", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@usuario", SqlDbType.VarChar, 25).Value = usuario;
                Comando.Parameters.Add("@contrasena", SqlDbType.VarChar, 25).Value = contraseña;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                Usuario pusuario = null;
                while (Leer.Read())
                {
                    pusuario = new Usuario();
                    pusuario.Id = (int)Leer["Id"];
                    pusuario.Nombre = (string)Leer["Nombre"];
                    pusuario.Apellidos = (string)Leer["Apellidos"];
                    pusuario.PUsuario = (string)Leer["Usuario"];
                    pusuario.Contraseña = (string)Leer["Contraseña"];

                }
                return pusuario;
            }

        }
    }
}

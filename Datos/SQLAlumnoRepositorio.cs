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
    public class SQLAlumnoRepositorio:IAlumnoRepositorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;
        public Alumno ObtenerAlumnoPorNombreOExpediente(string Nombre, int expediente)
        {
            throw new NotImplementedException();
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paModificarAlumno", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idalumno", SqlDbType.Int).Value = alumno.Id;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = alumno.Nombre;
                Comando.Parameters.Add("@apellidos", SqlDbType.VarChar, 100).Value = alumno.Apellidos;
                Comando.Parameters.Add("@expediente", SqlDbType.Int).Value = alumno.Expediente;
                conexion.Open();
                Comando.ExecuteNonQuery();
            }
        }

        public void EliminarAlumno(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paEliminarAlumno", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idalumno", SqlDbType.Int).Value = id;
                conexion.Open();
                Comando.ExecuteNonQuery();
            }
        }

        public Alumno ObtenerAlumnoPorId(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paSeleccionarAlumnoPorID", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idalumno", SqlDbType.Int).Value = id;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                Alumno alumno = null;
                while (Leer.Read())
                {
                    alumno = new Alumno();
                    alumno.Id = (int)Leer["Id"];
                    alumno.Nombre = (string)Leer["Nombre"];
                    alumno.Apellidos = (string)Leer["Apellidos"];
                    alumno.Expediente = (int)Leer["Expediente"];
                

                }
                return alumno ;

            }
        }


        public IEnumerable<Alumno> ObtenerAlumnos()
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerAlumnos", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Alumno> alumnos = new List<Alumno>();
                while (Leer.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = (int)Leer["Id"];
                    alumno.Nombre = (string)Leer["Nombre"];
                    alumno.Apellidos = (string)Leer["Apellidos"];
                    alumno.Expediente = (int)Leer["Expediente"];
                    alumnos.Add(alumno);

                }
                return alumnos;

            }
        }






        public IEnumerable<Alumno> ObtenerAlumnosPorNombreOExpediente(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paSeleccionarAlumnosPorNombreOExpediente", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Alumno> alumnos = new List<Alumno>();
                while (Leer.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = (int)Leer["Id"];
                    alumno.Nombre = (string)Leer["Nombre"];
                    alumno.Apellidos = (string)Leer["Apellidos"];
                    alumno.Expediente = (int)Leer["Expediente"];
                    alumnos.Add(alumno);

                }
                return alumnos;

            }
        }



        public IEnumerable<Alumno> ObtenerAlumnosPorTurnoYGrupo(int idTurno, int idGrupo)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paSeleccionarAlumnosPorGrupoyTurno", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idturno", SqlDbType.Int).Value = idTurno;
                Comando.Parameters.Add("@idgrupo", SqlDbType.Int).Value = idGrupo;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<Alumno> alumnos = new List<Alumno>();
                while (Leer.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = (int)Leer["Id"];
                    alumno.Nombre = (string)Leer["Nombre"];
                    alumno.Apellidos = (string)Leer["Apellidos"];
                    alumno.Expediente = (int)Leer["Expediente"];
                    alumnos.Add(alumno);

                }
                return alumnos;

            }
        }


        public void AgregarAlumno(Alumno alumno, int idgrupo, int idturno)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paGuardarAlumno", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idturno", SqlDbType.Int).Value = idturno;
                Comando.Parameters.Add("@idgrupo", SqlDbType.Int).Value = idgrupo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = alumno.Nombre;
                Comando.Parameters.Add("@apellidos", SqlDbType.VarChar, 100).Value = alumno.Apellidos;
                Comando.Parameters.Add("@expediente", SqlDbType.Int).Value = alumno.Expediente;
                conexion.Open();
                Comando.ExecuteNonQuery();
            }
        }
    }
}

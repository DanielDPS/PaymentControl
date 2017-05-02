using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Datos
{
    public interface IAlumnoRepositorio
    {
        Alumno ObtenerAlumnoPorId(int id);
        IEnumerable<Alumno> ObtenerAlumnos();
        IEnumerable<Alumno> ObtenerAlumnosPorNombreOExpediente(string nombre);
        IEnumerable<Alumno> ObtenerAlumnosPorTurnoYGrupo(int idTurno,int idGrupo);
        Alumno ObtenerAlumnoPorNombreOExpediente(string Nombre,int expediente);
        void AgregarAlumno(Alumno alumno,int idgrupo,int idturno);
        void ActualizarAlumno(Alumno alumno);
        void EliminarAlumno(int id);
        

    }
}

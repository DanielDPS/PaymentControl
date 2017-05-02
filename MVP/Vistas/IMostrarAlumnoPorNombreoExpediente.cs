using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarAlumnoPorNombreoExpediente
    {
        string Nombrealumno { get; }
 
        void MostrarAlumnoporNombre(IEnumerable<Alumno> alumnos);
        void ErrorAlumnosporNombre(string errorAlumnosPorNombre);

    }
}

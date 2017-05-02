using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarAlumnos
    {
        void MostrarAlumnos(IEnumerable<Alumno> alumnos);
        void ErrorAlumnos(string errorAlumnos);
    }
}

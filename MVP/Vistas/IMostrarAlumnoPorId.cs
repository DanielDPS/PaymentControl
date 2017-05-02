using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
  public   interface IMostrarAlumnoPorId
    {
      int IdAlumno { get; }
      void Mostraralumno(Alumno gAlumno);
      void ErrorAlumno(string errorAlumno);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public  interface IAgregarAlumno
    {
        int idgrupo { get; }
        int idturno { get; }
        Alumno alumno { get; }
        void AgregarAlumno(string mensaje);
        void ErrorAlumno(string errorAlumno);
    }
}

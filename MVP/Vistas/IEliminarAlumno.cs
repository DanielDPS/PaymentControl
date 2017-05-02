using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Vistas
{
   public  interface IEliminarAlumno
    {
       int idAlumno { get; }
       void EliminarAlumno(string mensaje);
       void ErrorEliminarAlumno(string erroreliminar);
    }
}

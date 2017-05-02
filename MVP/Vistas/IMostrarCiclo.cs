using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
   public  interface IMostrarCiclo
    {
       Ciclo GCiclo { get; }
       void Correcto(Ciclo gCiclo);
       void ErrorAlumnos(string error);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public interface IMostrarCicloFecha
    {
        int  GCicloFecha { get; }
        void Correcto(FCiclo gCicloFecha);
        void ErrorAlumnos(string error);
    }
}

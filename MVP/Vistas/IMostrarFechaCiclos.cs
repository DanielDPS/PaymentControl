using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public  interface IMostrarFechaCiclos
    {
        int _FkAlumno { get; }
        void MostrarFechasCiclo(IEnumerable<FCiclo> gFechaCiclos);
        void ErrorFechasCiclo(string error);
    }
}

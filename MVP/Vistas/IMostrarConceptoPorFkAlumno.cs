using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
   public  interface IMostrarConceptoPorFkAlumno
    {
       int _FkAlumno { get; }
       void MostrarConceptorPorId(IEnumerable<Concepto> conceptos);
       void ErrorConceptosPorId(string errorConceptos);
    }
}

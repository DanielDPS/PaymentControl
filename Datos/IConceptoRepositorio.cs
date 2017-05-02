using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
    public  interface IConceptoRepositorio
    {
        IEnumerable<Concepto> ObtenerConceptos();
        IEnumerable<Concepto> ObtenerConceptosPorFkAlumno(int id);
        Concepto ObtenerConcepto(int fkciclo);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
   public  interface IConceptoPorCiclo
    {
       int  _CicloId { get; }
       void MostrarConceptoPorCiclo(Concepto gConcepto);
       void ErrorConceptoPorCiclo(string errorConceptoCiclo);

    }
}

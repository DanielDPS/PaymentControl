using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ConceptoCostoCiclo
    {
       public int _FkCosto { get; set; }
       public int _FkConcepto { get; set; }
       public int _FkCiclo { get; set; }

    }
}

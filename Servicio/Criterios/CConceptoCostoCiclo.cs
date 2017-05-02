using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Criterios
{
   public  class CConceptoCostoCiclo
    {
        public int FkCosto { get; set; }
        public int FkConcepto { get; set; }
        public int FkCiclo { get; set; }
    }
}

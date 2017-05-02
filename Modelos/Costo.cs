using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Costo
    {
        public int Id { get; set; }
        public int Precio { get; set; }
        public int Fkciclo { get; set; }
        public int FkconceptoCosto { get; set; }
    }
}

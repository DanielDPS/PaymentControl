using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Objetos
{
    public class RespuestaBase
    {
        public bool Correcto { get; set; }
        public Exception Excepcion { get; set; }
    }
}

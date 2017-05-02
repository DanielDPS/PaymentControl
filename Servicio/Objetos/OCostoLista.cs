using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Servicio.Objetos
{
    public class OCostoLista:RespuestaBase
    {
        public IEnumerable<Costo> ListaCostos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
   public interface IMostrarGrupos
    {
        int _Idciclo { get; }
       void Correcto(IEnumerable<Grupo> gGrupos);
       void ErrorPago(string error);
    }
}

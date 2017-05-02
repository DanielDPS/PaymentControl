using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace MVP.Vistas
{
    public  interface IMostrarCostosPorConcepto
    {
        int _FkCicloMes { get; }
        void MostrarCostosPorConepto(IEnumerable<Costo> gCostos);
        void ErrorCostos(string errorCostos);
    }
}

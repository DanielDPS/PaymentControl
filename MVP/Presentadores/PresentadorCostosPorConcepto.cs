using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using Servicio.Criterios;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public class PresentadorCostosPorConcepto
    {
        private IMostrarCostosPorConcepto Imostrarconceptos;
        private ServicioCosto servicioCostos;
        public PresentadorCostosPorConcepto(ICostoRepositorio IcostoR, IMostrarCostosPorConcepto vista)
        {
            servicioCostos = new ServicioCosto(IcostoR);
            Imostrarconceptos = vista;
        }
        public void PresentarCostosPorConcepto()
        {
            CCosto ccostos = new CCosto();
            ccostos.FkConcepto = Imostrarconceptos._FkCicloMes;
            OCostoLista listadocostos = servicioCostos.ObtenerCostosporFkConcepto(ccostos);
            if (listadocostos.Correcto)
                Imostrarconceptos.MostrarCostosPorConepto(listadocostos.ListaCostos);
            else
                Imostrarconceptos.ErrorCostos(string.Format("{0}",listadocostos.Excepcion.Message));
        }
    }
}

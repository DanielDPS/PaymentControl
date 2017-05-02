using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public  class PresentadorPagosDetalle
    {
        private IMostrarPagosDetalle ImostrarPagosDetalle;
        private ServicioPago servicioPago;

        public PresentadorPagosDetalle(IPagoRepositorio IpagoR, IMostrarPagosDetalle vista)
        {
            servicioPago = new ServicioPago(IpagoR);
            ImostrarPagosDetalle = vista;
        }
        public void PresentarPagosDetalle()
        {
            OPagoLista listaPagos = servicioPago.ObtenerPagosDetalle();
            if (listaPagos.Correcto)
                ImostrarPagosDetalle.MostrarPagosDetalle(listaPagos.pagosDetalleLista);
            else
                ImostrarPagosDetalle.ErrorPagosDetalle(string.Format("{0}",listaPagos.Excepcion.Message));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using MVP.Vistas;
using Servicio.Criterios;
using Servicio.Objetos;
namespace MVP.Presentadores
{
    public  class PresentadorPago
    {
        private IAgregarPago IagregarPago;
        private ServicioPago servicioPago;
        public PresentadorPago(IPagoRepositorio Ipr, IAgregarPago vista)
        {
            servicioPago = new ServicioPago(Ipr);
            IagregarPago = vista;
        }

        public void PresentarPago()
        {
            CPago cpago = new CPago();
            cpago._Pago = IagregarPago.pago;
            OPago opago = servicioPago.EjecutarPago(cpago);
            if (opago.Correcto)
            {
                IagregarPago.PagoCorrecto("se realizo el pago");

            }
            else
            {
                IagregarPago.ErrorPago(string.Format("{0}",opago.Excepcion.Message));
            }
        }
    }
}

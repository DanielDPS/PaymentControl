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
    public class PresentadorPagosPorAlumno
    {
        private IBuscarPagosPorAlumno ibusqueda;
        private ServicioPago servicioPago;
        public PresentadorPagosPorAlumno(IPagoRepositorio ipago, IBuscarPagosPorAlumno vista)
        {
            servicioPago = new ServicioPago(ipago);
            ibusqueda = vista;
        }
        public void PresentarPagoPorAlumno()
        {
            OPagoLista listadoPagos = servicioPago.ObtenerPagosDetalle();
            CPago cpago = new CPago();
            cpago._Filtro = ibusqueda.FiltroNomre;
            OPagoLista listado = servicioPago.ObtenerPagosPorAlumno(cpago);
            if (listado.Correcto)
            {

                if (cpago._Filtro == null)

                    ibusqueda.MostrarPagosPorAlumno(listadoPagos.pagosDetalleLista);
                else
                    ibusqueda.MostrarPagosPorAlumno(listado.detalles);
            }
            else
                ibusqueda.ErrorPagosPorAlumno(string.Format("{0}", listado.Excepcion.Message));

        }
    }
}

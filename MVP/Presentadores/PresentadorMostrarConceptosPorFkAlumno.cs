using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Servicio;
using Datos;
using Servicio.Criterios;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public  class PresentadorMostrarConceptosPorFkAlumno
    {
        private IMostrarConceptoPorFkAlumno Imostrarconceptos;
        private ServicioConcepto servicioConcepto;

        public PresentadorMostrarConceptosPorFkAlumno(IConceptoRepositorio IconceptoR, IMostrarConceptoPorFkAlumno vista)
        {
            servicioConcepto = new ServicioConcepto(IconceptoR);
            Imostrarconceptos = vista;
        }

        public void PresentarConceptosPorFkAlumno()
        {
            CConcepto cconcepto = new CConcepto();
            cconcepto.FkAlumno = Imostrarconceptos._FkAlumno;
            OConceptoLista listaConceptos = servicioConcepto.ObtenerListadoConceptos(cconcepto);
            if (listaConceptos.Correcto)
                Imostrarconceptos.MostrarConceptorPorId(listaConceptos.ListaConcepto);
            else
                Imostrarconceptos.ErrorConceptosPorId(string.Format("{0}",listaConceptos.Excepcion.Message));

        }
    }
}

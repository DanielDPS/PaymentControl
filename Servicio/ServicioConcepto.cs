using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Servicio.Criterios;
using Datos;
using Servicio.Objetos;
namespace Servicio
{
    public class ServicioConcepto
    {
        private IConceptoRepositorio IconceptoR;
        public ServicioConcepto(IConceptoRepositorio ICR)
        {
            IconceptoR = ICR;
        }
                public OConcepto ObtenerConceptoPorCiclo(CConcepto cconcepto)
        {
            OConcepto oconcepto = new OConcepto();
            try
            {
                Concepto concepto = IconceptoR.ObtenerConcepto(cconcepto.FKCiclo);
                if (concepto != null)
                {
                    oconcepto._Concepto = concepto;
                    oconcepto.Correcto = true;
                }
                else
                {
                    oconcepto.Correcto = false;
                }

            }
            catch (Exception e )
            {

            }
            return oconcepto;
        }



        public OConceptoLista ObtenerListadoConceptos(CConcepto cconcepto)
        {
            OConceptoLista listado = new OConceptoLista();
            try
            {
                IEnumerable<Concepto> conceptos = IconceptoR.ObtenerConceptosPorFkAlumno(cconcepto.FkAlumno);
                listado.ListaConcepto = conceptos;
                listado.Correcto = true;
            }
            catch (Exception e )
            {
                listado.Excepcion = e;
                listado.Correcto = false;
                
            }
            return listado;

        }

        public OConceptoLista ObtenerConceptos()
        {
            OConceptoLista listaConceptos = new OConceptoLista();
            try
            {
                IEnumerable<Concepto> conceptos = IconceptoR.ObtenerConceptos();
                listaConceptos.ListaConcepto = conceptos;
                listaConceptos.Correcto = true;
            }
            catch (Exception e )
            {
                listaConceptos.Excepcion = e;
                listaConceptos.Correcto = false;
                
            }
            return listaConceptos;


        }
    }
}

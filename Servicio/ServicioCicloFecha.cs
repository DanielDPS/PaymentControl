using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using Servicio;
using Servicio.Criterios;
using Servicio.Objetos;
namespace Servicio
{
    public class ServicioCicloFecha
    {
        private ICicloFechaRepositorio IciclofechaR;
        public ServicioCicloFecha(ICicloFechaRepositorio ICFR)
        {
            IciclofechaR = ICFR;
        }
        public OCicloFechaLista ObtenerFechaCicloPorFkAlumno(CCicloFecha cciclo)
        {
            OCicloFechaLista listado = new OCicloFechaLista();
            try
            {
                IEnumerable<FCiclo> ciclos = IciclofechaR.ObtenerCicloFechaPorFkAlumno(cciclo.FkAlumno);
                listado.ListaCicloFecha = ciclos;
                listado.Correcto = true;
            }
            catch (Exception e)
            {
                listado.Excepcion = e;
                listado.Correcto = false;       
            }
            return listado;

        }

        public OCicloFecha ObtenerCicloFechaPorId(CCicloFecha cciclofecha)
        {
            OCicloFecha ociclofecha = new OCicloFecha();
            try
            {
                    FCiclo ciclo = IciclofechaR.ObtenerCicloFechaPorId(cciclofecha.IdCicloFecha);
                    ociclofecha._CicloFecha = ciclo;
                    ociclofecha.Correcto = true;
            }
            catch (Exception e )
            {
                ociclofecha.Excepcion = e;
                ociclofecha.Correcto = false;
                
                
            }
            return ociclofecha;

        }
    }
}

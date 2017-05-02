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
using MVP.Vistas;
namespace MVP.Presentadores
{
    public  class PresentadorCicloFecha
    {
        private IMostrarCicloFecha ImostrarCicloFecha;
        private ServicioCicloFecha servicioCicloFecha;
        public PresentadorCicloFecha(ICicloFechaRepositorio IcicloFechaR, IMostrarCicloFecha view)
        {
            servicioCicloFecha = new ServicioCicloFecha(IcicloFechaR);
            ImostrarCicloFecha = view;
        }

        public void PresentarCicloFecha()
        {
            CCicloFecha cciclof = new CCicloFecha();
            cciclof.IdCicloFecha = ImostrarCicloFecha.GCicloFecha;
            OCicloFecha ociclofecha = servicioCicloFecha.ObtenerCicloFechaPorId(cciclof);
            if (ociclofecha.Correcto)
            {

                ImostrarCicloFecha.Correcto(ociclofecha._CicloFecha);
            }
            else
            {
                ImostrarCicloFecha.ErrorAlumnos(string.Format("{0}",ociclofecha.Excepcion.Message));
            }

        }
    }
}

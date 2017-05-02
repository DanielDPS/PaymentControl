using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Criterios;
using Servicio.Objetos;
using MVP.Vistas;
using Servicio;
namespace MVP.Presentadores
{
   public  class PresentadorMostrarCicloFecha
    {
       private IMostrarFechaCiclos Ifechas;
       private ServicioCicloFecha servicioCicloFecha;
       public PresentadorMostrarCicloFecha(ICicloFechaRepositorio IcicloFechaR, IMostrarFechaCiclos vista)
       {
           servicioCicloFecha = new ServicioCicloFecha(IcicloFechaR);
           Ifechas = vista;
       }
       public void PresentarFechaCiclos()
       {
           CCicloFecha ccicloFechas = new CCicloFecha();
           ccicloFechas.FkAlumno = Ifechas._FkAlumno;
           OCicloFechaLista listaFechas = servicioCicloFecha.ObtenerFechaCicloPorFkAlumno(ccicloFechas);
           if (listaFechas.Correcto)
               Ifechas.MostrarFechasCiclo(listaFechas.ListaCicloFecha);
           else 
               Ifechas.ErrorFechasCiclo(string.Format("{0}",listaFechas.Excepcion.Message));

       }
    }
}

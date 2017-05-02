using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Servicio;
using Datos;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
   public  class PresentadorCiclos
    {
       private IMostrarCiclos iciclos;
       private ServicioCiclo servicioCiclo;
       public PresentadorCiclos(ICicloRepositorio IcicloR, IMostrarCiclos vista)
       {
           servicioCiclo = new ServicioCiclo(IcicloR);
           iciclos = vista;
       }
       public void PresentarCiclos()
       {
           OCicloLista lista = servicioCiclo.ObtenerCilos();
           if (lista.Correcto)
               iciclos.MostrarCiclos(lista._CilosLista);
           else
               iciclos.ErrorMostrarCiclos(string.Format("{0}",lista.Excepcion.Message));

       }
    }
}

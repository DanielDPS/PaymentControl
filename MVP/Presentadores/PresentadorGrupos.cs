using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using Servicio.Objetos;
using Servicio.Criterios;
using MVP.Vistas;
namespace MVP.Presentadores
{
   public class PresentadorGrupos
    {

       private IMostrarGrupos Igrupos;
       private ServicioGrupo servicioGrupo;
       public PresentadorGrupos(IGrupoRepositorio IGR,IMostrarGrupos vista)
       {
           servicioGrupo = new ServicioGrupo(IGR);
           Igrupos = vista;

       }

       public void PresentarGrupos()
       {
           CGrupo cgrupo = new CGrupo();
           cgrupo.Idciclo = Igrupos._Idciclo;
           OGrupoLista listado = servicioGrupo.ObtenerGrupos(cgrupo);
           if (listado.Correcto)
           {
               Igrupos.Correcto(listado._Grupos);
           }
           else
           {
               Igrupos.ErrorPago(string.Format("{0}",listado.Excepcion.Message));
           }
       }

    }
}

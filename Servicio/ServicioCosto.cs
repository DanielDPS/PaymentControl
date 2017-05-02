using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Objetos;
using Servicio.Criterios;
namespace Servicio
{
    public class ServicioCosto
    {
        private ICostoRepositorio IcostoRepositorio;
        public ServicioCosto(ICostoRepositorio icr)
        {
            IcostoRepositorio = icr;
        }

        public OCostoLista ObtenerCostosporFkConcepto(CCosto ccosto)
        {
            OCostoLista listadoCostos = new OCostoLista();
            try
            {
                IEnumerable<Costo> costos = IcostoRepositorio.ObtenerCostos(ccosto.FkConcepto);
                listadoCostos.ListaCostos = costos;
                listadoCostos.Correcto = true;
            }
            catch (Exception e)
            {

                listadoCostos.Excepcion = e;
                listadoCostos.Correcto = false;
            }
            return listadoCostos;
        }
        
    }
}

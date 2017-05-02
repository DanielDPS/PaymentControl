using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using Servicio;
using Servicio.Objetos;
using Servicio.Criterios;
namespace Servicio
{
    public class ServicioCiclo
    {
        private ICicloRepositorio IcicloR;
        public ServicioCiclo(ICicloRepositorio Icr)
        {
            IcicloR = Icr;

        }


        public OCicloLista ObtenerCilos()
        {
            OCicloLista lista = new OCicloLista();
            try
            {
                List<Ciclo> ciclos = IcicloR.ObtenerCiclos();
                lista._CilosLista = ciclos;
                lista.Correcto = true;

            }
            catch (Exception e)
            {
                lista.Excepcion = e;
                lista.Correcto = false;
            }
            return lista;
        }

        public OCiclo ObtenerCicloPorID(CCiclo cciclo)
        {
              OCiclo ociclo = new OCiclo();
              try
              {
                  Ciclo ciclo = IcicloR.ObtenerCicloPorId(cciclo.IdCiclo);
                  if (ciclo.Id.Equals(cciclo.IdCiclo))
                  {
                      ociclo.OBCiclo = ciclo;
                      ociclo.Correcto = true;
                  }
                  else
                  {
                      ociclo.Correcto = false;

                  }
              }
              catch (Exception)
              {
                 
              }
              
              
            return ociclo;
        }

    }
}

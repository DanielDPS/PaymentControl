using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Criterios;
using Servicio.Objetos;
namespace Servicio
{
    public  class ServicioGrupo
    {
        private IGrupoRepositorio IgrupoRepositorio;
        public ServicioGrupo(IGrupoRepositorio Igr)
        {
            IgrupoRepositorio = Igr;
        }

        public OGrupoLista ObtenerGrupos(CGrupo cgrupo)
        {
            OGrupoLista ogrupo = new OGrupoLista();
            try
            {
                IEnumerable<Grupo> grupos = IgrupoRepositorio.ObtenerTodoslosGrupos(cgrupo.Idciclo);

                    ogrupo._Grupos = grupos;
                    ogrupo.Correcto = true;

                 

            }
            catch (Exception e  )
            {
                ogrupo.Excepcion = e;
                ogrupo.Correcto = false;
            }
            return ogrupo;

        }
    }

}

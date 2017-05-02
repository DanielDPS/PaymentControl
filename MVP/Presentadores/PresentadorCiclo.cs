using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Servicio;
using Modelos;
using MVP.Vistas;
using Servicio.Criterios;
using Servicio.Objetos;
namespace MVP.Presentadores
{
    public class PresentadorCiclo
    {

        private IMostrarCiclo Imostrasciclo;
        private ServicioCiclo servicioCiclo;
        public PresentadorCiclo(ICicloRepositorio ICR, IMostrarCiclo view)
        {
            servicioCiclo = new ServicioCiclo(ICR);
            Imostrasciclo = view;
        }

        public void PresentarCiclo()
        {
            CCiclo cciclo = new CCiclo();
            cciclo.IdCiclo =Imostrasciclo.GCiclo.Id;
            OCiclo ociclo = servicioCiclo.ObtenerCicloPorID(cciclo);
            if (ociclo.Correcto)
            {
                Imostrasciclo.Correcto(ociclo.OBCiclo);
            }
            else
            {
                Imostrasciclo.ErrorAlumnos(string.Format("{0}","Error al intentar mostrar"));
            }

        }
    }
}

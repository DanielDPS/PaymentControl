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
    public class PresentadorMostrarMesesPorCiclo
    {
        private IMostrarMesesPorCiclo Imeses;
        private ServicioMes servicioMeses;
        public PresentadorMostrarMesesPorCiclo  (IMesReporitorio ImesR,IMostrarMesesPorCiclo vista)
        {
            servicioMeses = new ServicioMes(ImesR);
            Imeses = vista;
        }

        public void PresentarMesesPorCiclo()
        {
            CMes cmes = new CMes();
            cmes.Fkciclo = Imeses._Fkciclo;
            OListaMes listaMeses = servicioMeses.ObtenerMesesPorCiclo(cmes);
            if (listaMeses.Correcto)
                Imeses.MostrarMesesPorCiclo(listaMeses.Listames);
            else
                Imeses.ErrorMesesPorCiclo(string.Format("{0}",listaMeses.Excepcion.Message));
        }
    }
}

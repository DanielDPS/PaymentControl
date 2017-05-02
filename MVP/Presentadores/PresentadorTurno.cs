using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio;
using Servicio.Objetos;
using MVP.Vistas;
namespace MVP.Presentadores
{
    public class PresentadorTurno
    {
        private IMostrarTurnos Iturnos;
        private ServicioTurno servicioTurno;
        public PresentadorTurno(ITurnoRepositorio Itr, IMostrarTurnos vista)
        {
            servicioTurno = new ServicioTurno(Itr);
            Iturnos = vista;
        }

        public void PresentarTurnos()
        {
            OTurnoLista listado = servicioTurno.ObtenerTurnos();
            if (listado.Correcto)
                Iturnos.MostrarTurnos(listado.TurnoLista);
            else
                Iturnos.ErrorTurnos(string.Format("{0}",listado.Excepcion.Message));
        }
    }
}

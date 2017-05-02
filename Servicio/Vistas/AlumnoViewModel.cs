using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Vistas
{
    public class AlumnoViewModel
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Expediente { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
    }
}

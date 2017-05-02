using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Ciclo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public bool Activo { get; set; }
        public string Periodo { get; set; }
        public int Fksemestre { get; set; }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class FCiclo
    {
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Fkciclo { get; set; }
        public string AñoFecha
        {
            get
            {
                return Inicio.Year + "-" + Fin.Year;
            }

        }
    }
}

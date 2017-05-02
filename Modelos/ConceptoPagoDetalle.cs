using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public  class ConceptoPagoDetalle
    {
        public int Expediente { get; set; }
        public string Alumno { get; set; }
        public int Pago { get; set; }
        public string Mes { get; set; }
        public int  NumeroMes { get; set; }
        public int Folio { get; set; }
        public int FkAlumnoGT { get; set; }
        public int FkConceptoCostoC { get; set; }
    }
}

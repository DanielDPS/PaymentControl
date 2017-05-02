using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;
using Servicio.Objetos;
using Servicio.Criterios;
using Servicio;
namespace Servicio
{
   public   class ServicioSemestre
    {

       public ISemestreRepositorio IsemestreR;
       public ServicioSemestre(ISemestreRepositorio ISR)
       {
           IsemestreR = ISR;
       }

       public OSemestre ObtenerSemestrePorId(CSemestre csemestre)
       {
           OSemestre osemestre = new OSemestre();
           try
           {
               Semestre semestre = IsemestreR.ObtenerSemestrePorId(csemestre.IdSemestre);
                   osemestre._Semestre = semestre;
                   osemestre.Correcto = true;
                   

           }
           catch (Exception e)
           {
               osemestre.Excepcion = e;
               osemestre.Correcto = false;
           }
           return osemestre;

       }
    }
}

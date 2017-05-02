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
   public  class ServicioMes
    {
       private IMesReporitorio Imesrepositorio;
       public ServicioMes(IMesReporitorio Imesr)
       {
           Imesrepositorio = Imesr;
       }
       public OListaMes ObtenerMesesPorCiclo(CMes cmes)
       {
           OListaMes lista = new OListaMes();
           try
           {
               IEnumerable<Mes> meses = Imesrepositorio.ObtenerMesesPorFkCiclo(cmes.Fkciclo);
               lista.Listames = meses;
               lista.Correcto = true;
           }
           catch (Exception e ) 
           {
               lista.Excepcion = e;
               lista.Correcto = false;
              
           }
           return lista;
       }
    }
}

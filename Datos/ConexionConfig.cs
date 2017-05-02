using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public static  class ConexionConfig
    {
       private static SqlConnectionStringBuilder _Conexion;
       public static string Cadena
       {
           get
           {
                   _Conexion = new SqlConnectionStringBuilder
                   {
                       ConnectionString = ConfigurationManager.ConnectionStrings["DBControlDePagos"].ConnectionString
                   };
               return _Conexion.ToString();
           }
       }
    }
}

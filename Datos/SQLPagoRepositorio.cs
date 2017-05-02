using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public  class SQLPagoRepositorio:IPagoRepositorio
    {
        private SqlCommand Comando;
        private SqlDataReader Leer;
        public void RealizarPago(ConceptoPago pago)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paInsertarPago", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idout", SqlDbType.Int).Direction = ParameterDirection.Output;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = pago.Fecha;
                Comando.Parameters.Add("@hora", SqlDbType.Time).Value = pago.Hora.Hour.ToString();
                conexion.Open();
                Comando.ExecuteNonQuery();
                pago.Id = (int)Comando.Parameters["@idout"].Value;
                conexion.Close();

                foreach (ConceptoPagoDetalle  detallepago in pago.detalle)
                {
                    Comando = new SqlCommand("paInsertarPagoDetalle", conexion);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@pago", SqlDbType.Int).Value = detallepago.Pago;
                    Comando.Parameters.Add("@mes", SqlDbType.VarChar, 20).Value = detallepago.NumeroMes;
                    Comando.Parameters.Add("@fkpago", SqlDbType.Int).Value = pago.Id;
                    Comando.Parameters.Add("@fkalumnoGT", SqlDbType.Int).Value = detallepago.FkAlumnoGT;
                    Comando.Parameters.Add("@fkcostoCC", SqlDbType.Int).Value = detallepago.FkConceptoCostoC;
                    Comando.Parameters.Add("@fkconcepto", SqlDbType.Int).Value = detallepago.Pago;
                    Comando.Parameters.Add("@foliopago", SqlDbType.VarChar, 5).Value = "115";


                    conexion.Open();
                    Comando.ExecuteNonQuery();
                    conexion.Close();
                    
                }

            }
            
        }



        public IEnumerable<ConceptoPagoDetalle> MostrarPagos()
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paObtenerListadoDePagos", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<ConceptoPagoDetalle> pagodetalle = new List<ConceptoPagoDetalle>();
                while (Leer.Read())
                {
                    ConceptoPagoDetalle pago = new ConceptoPagoDetalle();
                    pago.Expediente = (int)Leer["expediente"];
                    pago.Alumno = (string)Leer["nombre"];
                    pago.Pago = (int)Leer["pago"];
                    pago.NumeroMes = (int)Leer["mes"];
                    pago.Folio = (int)Leer["folio"];
                    pago.FkAlumnoGT = (int)Leer["fkalumnogt"];
                    pago.FkConceptoCostoC = (int)Leer["conceptocc"];
                    pago.Mes = (string ) Leer["smes"];

                    pagodetalle.Add(pago);

                }
                return pagodetalle;

            }
        }


        public IEnumerable<ConceptoPagoDetalle> MostrarPagosPorAlumno(string filtro)
        {
            using (SqlConnection conexion = new SqlConnection(ConexionConfig.Cadena))
            {
                Comando = new SqlCommand("paBuscarPagosAlumnosPorNombre", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@filtro", SqlDbType.VarChar, 10).Value = filtro;
                conexion.Open();
                Leer = Comando.ExecuteReader();
                List<ConceptoPagoDetalle> pagodetalle = new List<ConceptoPagoDetalle>();
                while (Leer.Read())
                {
                    ConceptoPagoDetalle pago = new ConceptoPagoDetalle();
                    pago.Pago = (int)Leer["Pago"];
                    pago.NumeroMes = (int)Leer["Mes"];

                    pagodetalle.Add(pago);

                }
                return pagodetalle;

            }
           
        }
    }
}

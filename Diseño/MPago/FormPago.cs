using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using MVP.Presentadores;
using System.IO;
using System.Xml.Serialization;
using MVP.Vistas;
using Servicio;
using Modelos;
using Servicio.Criterios;
using Servicio.Vistas;
using Microsoft.CSharp;
using System.Globalization;
using Servicio.Conversiones;
namespace Diseño.MPago
{
    public partial class FormPago : Form,IMostrarCiclos,IConceptoPorCiclo,IMostrarCostosPorConcepto,IMostrarMesesPorCiclo
        , IAgregarPago, IMostrarGrupos, IMostrarTurnos,IMostrarIdGrupoAlumnoTC
     
        , IMostrarPagosDetalle, IBuscarPagosPorAlumno, IMostrarAlumno,IMostrarConceptoCostoCiclo
        

    {
        private PresentadorGrupoAlumnoTC presentadorGrupoAlumnoTC;
        private PresentadorConceptoCostoCiclo presentadorConceptoCC;
        private PresentadorCiclos presentadorCiclos=null;
        private PresentadorConceptoPorCiclo presentadorConceptoPorCiclo=null;
        private PresentadorCostosPorConcepto presentadorCostosPorConcepto=null;
        private PresentadorMostrarMesesPorCiclo presentadorMesesPorCiclo = null;
        private int fkconceptoConceptoCostoCiclo,fkidGrupoAlumnoTC,idConcepto = 0;
        GrupoAlumnoTC grupoAlumnoTC;
        ConceptoCostoCiclo oconceptoCostoCiclo;
        List<ConceptoPagoDetalle> listPagosDetalle;
        private PresentadorPagosDetalle presentadorPagosDetalle;
        private PresentadorAlumnos presentadorAlumnosPorGrupoYTurno;
        private PresentadorPago presentadorPago;
        private PresentadorGrupos presentadorGrupos;
        private PresentadorTurno presentadorTurnos;
        private PresentadorPagosPorAlumno presentadorPagosPorAlumno;
        private ConceptoPagoDetalle _DetallePago;
        private CarroPago _CarroPago;
        Turno turno;
        Ciclo ciclo;
        Grupo grupo;
        Costo costos;
        Mes meses;
        AlumnoViewModel alumnoModel;
        public FormPago()
        {
            InitializeComponent();
            turno = new Turno();
            ciclo = new Ciclo();
            grupo = new Grupo();
            costos = new Costo();
            meses = new Mes();
            alumnoModel = new AlumnoViewModel();
            presentadorCiclos = new PresentadorCiclos(new SQLCicloRepositorio(),this);
            presentadorCiclos.PresentarCiclos();

            _DetallePago = new ConceptoPagoDetalle();
            _CarroPago = new CarroPago();
            presentadorPago = new PresentadorPago(new SQLPagoRepositorio(), this);
            grupoAlumnoTC = new GrupoAlumnoTC();
            oconceptoCostoCiclo = new ConceptoCostoCiclo();
            presentadorPagosDetalle = new PresentadorPagosDetalle(new SQLPagoRepositorio(), this);
            presentadorPagosDetalle.PresentarPagosDetalle();
         
        }
        private void timerHoraYFecha_Tick(object sender, EventArgs e)
        {
            lblHoraFecha.Text = DateTime.Now.ToString("G");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            turno = cmbTurnos.SelectedItem as Turno;
            ciclo = cmbCicloEscolar.SelectedItem as Ciclo;
            grupo = cmbGrupos.SelectedItem as Grupo;
            costos = cmbCostosMensuales.SelectedItem as Costo;
            meses = cmbMeses.SelectedItem as Mes;
          
            alumnoModel = cmbAlumnos.SelectedItem as AlumnoViewModel;
            grupoAlumnoTC._FkGrupo = grupo.Id;
            grupoAlumnoTC._FkAlumno = int.Parse( alumnoModel.Id);
            grupoAlumnoTC._FkTurno = turno.Id;
            grupoAlumnoTC._FkCiclo = ciclo.Id;

            oconceptoCostoCiclo._FkConcepto = idConcepto;
            oconceptoCostoCiclo._FkCosto = costos.Id;
            oconceptoCostoCiclo._FkCiclo = ciclo.Id;

            presentadorConceptoCC = new PresentadorConceptoCostoCiclo(new SQLConceptoCostoCiclo(), this);
            presentadorConceptoCC.PresentarIdConceptoCostoCiclo();
            presentadorGrupoAlumnoTC = new PresentadorGrupoAlumnoTC(new SQLGrupoAlumnoTC(),this );
            presentadorGrupoAlumnoTC.PresentarIdGrupoAlumnoTC();

            
            _DetallePago = costos.ConvertirACarroPago();
            _DetallePago.Expediente = int.Parse( alumnoModel.Expediente);
            _DetallePago.Alumno = alumnoModel.Nombre+" "+alumnoModel.Apellidos;
            _DetallePago.Mes = meses.Nombre;
            _DetallePago.Pago = costos.Precio;
            _DetallePago.NumeroMes = meses.Id;
            _DetallePago.FkAlumnoGT = fkidGrupoAlumnoTC;
            _DetallePago.FkConceptoCostoC = fkconceptoConceptoCostoCiclo;
          

                if (dgvPagosRealizados.Rows.Count == 0 )
                {
                    _CarroPago.AgregarPago(_DetallePago);
                    dgvPagos.DataSource = null;
                    dgvPagos.DataSource = _CarroPago.Lista;
                    presentadorPago.PresentarPago();
                    presentadorPagosDetalle.PresentarPagosDetalle();
                    dgvPagos.Columns["FkAlumnoGT"].Visible = false;
                    dgvPagos.Columns["FkConceptoCostoC"].Visible = false;
                    dgvPagos.Columns["NumeroMes"].Visible = false;
                    dgvPagos.Columns["Alumno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
                    dgvPagos.Columns["NumeroMes"].Visible = false;
                    dgvPagos.Columns["Folio"].Visible = false;
                    _CarroPago.LimpiarPago();
                    dgvPagos.DataSource = null;
                    this.Close();
                    FormPago frmpago = new FormPago();
                    frmpago.Show();


                }
                else
                {
                    foreach (ConceptoPagoDetalle row  in listPagosDetalle)
                    {

                        if (row.NumeroMes.Equals(meses.Id) && alumnoModel.Expediente.Equals(row.Expediente))
                        {
                            return;
                        }
                        else if (!_DetallePago.Expediente.Equals(row.Expediente) || !_DetallePago.NumeroMes.Equals(row.NumeroMes) || !_DetallePago.FkConceptoCostoC.Equals(row.FkConceptoCostoC) || !_DetallePago.FkAlumnoGT.Equals(row.FkAlumnoGT))
                        {
                            _CarroPago.AgregarPago(_DetallePago);
                            dgvPagos.DataSource = null;
                            dgvPagos.DataSource = _CarroPago.Lista;
                            dgvPagos.Columns["FkAlumnoGT"].Visible = false;
                            dgvPagos.Columns["FkConceptoCostoC"].Visible = false;
                            dgvPagos.Columns["NumeroMes"].Visible = false;
                            dgvPagos.Columns["Folio"].Visible = false;
                            dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        }
                        else
                        {
                            return;


                        }


                    }

                }





            
                
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvPagos.Rows.Count == 0)
            {
                MessageBox.Show("No se puede agregar si aun no hay registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                presentadorPago.PresentarPago();
                presentadorPagosDetalle.PresentarPagosDetalle();
                _CarroPago.LimpiarPago();
                dgvPagos.DataSource = null;
            }
           
        }
        public void Correcto(IEnumerable<Grupo> gGrupos)
        {
            cmbGrupos.DataSource = gGrupos;
            cmbGrupos.DisplayMember = "Nombre";
            cmbGrupos.ValueMember = "Id";
        }
        public void MostrarTurnos(IEnumerable<Turno> gTurnos)
        {
            cmbTurnos.DataSource = gTurnos;
            cmbTurnos.DisplayMember = "Nombre";
            cmbTurnos.ValueMember = "Id";
    
        }
        public void ErrorTurnos(string error)
        {
            MessageBox.Show(error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MostrarAlumnos(IEnumerable<AlumnoViewModel> alumnoviewmodel)
        {
            cmbAlumnos.DataSource = alumnoviewmodel;
            cmbAlumnos.DisplayMember = "NombreCompleto";
            cmbAlumnos.ValueMember = "Id";
          
        }
        private void cmbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            presentadorAlumnosPorGrupoYTurno = new PresentadorAlumnos(new SQLAlumnoRepositorio(), this);
            if (cmbTurnos.SelectedItem != null)
            {

                presentadorAlumnosPorGrupoYTurno.PresentarAlumnos();

            }
            else
                MessageBox.Show("No existe ningun turno seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cmbConceptos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cmbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public ConceptoPago pago
        {
            get
            {
                return _CarroPago.ConvertAPago();
            }
        }
        public void PagoCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ErrorPago(string error)
        {
            MessageBox.Show(error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgvPagos_KeyPress(object sender, KeyPressEventArgs e)
        {      
        }
        public void MostrarPagosDetalle(IEnumerable<ConceptoPagoDetalle> pagos)
        {
            dgvPagosRealizados.DataSource = null;
            dgvPagosRealizados.DataSource = pagos;
            dgvPagosRealizados.Columns["FkAlumnoGT"].Visible = false;
            dgvPagosRealizados.Columns["FkConceptoCostoc"].Visible = false;
           dgvPagosRealizados.Columns["NumeroMes"].Visible = false;
            dgvPagosRealizados.Columns["Folio"].Visible = false;
            listPagosDetalle = new List<ConceptoPagoDetalle>();
            listPagosDetalle = pagos as List<ConceptoPagoDetalle>;
        }

        public void ErrorPagosDetalle(string error)
        {
            MessageBox.Show(error);
        }


        private void dgvPagosRealizados_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConceptoPagoDetalle det = (ConceptoPagoDetalle)dgvPagosRealizados.Rows[dgvPagosRealizados.CurrentRow.Index].DataBoundItem;
            FormPagoreporte frmReportePago = new FormPagoreporte(det);
            frmReportePago.Show();
        }

        private void FormPago_Load(object sender, EventArgs e)
        {

        }

        private void txtBusquedaAlumno_TextChanged(object sender, EventArgs e)
        {
            //presentadorPagosPorAlumno = new PresentadorPagosPorAlumno(new SQLPagoRepositorio(), this);
            //presentadorPagosPorAlumno.PresentarPagoPorAlumno();
        }

        public string FiltroNomre
        {
            get { return txtBusquedaAlumno.Text; }
        }

        public void MostrarPagosPorAlumno(IEnumerable<ConceptoPagoDetalle> pagosAlumnos)
        {
            dgvPagosRealizados.DataSource = null;
            dgvPagosRealizados.DataSource = pagosAlumnos;
            dgvPagosRealizados.Columns["Codigo"].Visible = false;
            dgvPagosRealizados.Columns["FkCosto"].Visible = false;
            dgvPagosRealizados.Columns["FkConcepto"].Visible = false;
            dgvPagosRealizados.Columns["FkMes"].Visible = false;
            dgvPagosRealizados.Columns["Folio"].Visible = false;

        }

        public void ErrorPagosPorAlumno(string errorPagos)
        {
            MessageBox.Show(errorPagos, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        public int IdTurno
        {
            get
            {

                Turno turno = (Turno)cmbTurnos.SelectedItem;
                if (turno == null)
                    MessageBox.Show("No existe un turno");
                return turno.Id;
            }
        }

        public int IdGrupo
        {
            get
            {
                return (int ) cmbGrupos.SelectedValue;
            }
        }

        public void MostrarAlumnosPorTurnoYGrupo(IEnumerable<AlumnoViewModel> alumnoviewmodel)
        {
            cmbAlumnos.DataSource = alumnoviewmodel;
            cmbAlumnos.DisplayMember = "NombreCompleto";
            cmbAlumnos.ValueMember = "Id";

        }

        public void ErrorAlumnoPorGrupoYTurno(string error)
        {
            MessageBox.Show(error);
        }

        private void dgvPagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (dgvPagos.Rows.Count != 0)
                {
                    _CarroPago.EliminarPago(dgvPagos.CurrentRow.Index);
                    dgvPagos.DataSource = null;
                    dgvPagos.DataSource = _CarroPago.Lista;
                    dgvPagos.Columns["FkAlumnoGT"].Visible = false;
                    dgvPagos.Columns["FkConceptoCostoC"].Visible = false;
                    dgvPagos.Columns["NumeroMes"].Visible = false;
                }
                else
                    MessageBox.Show("No hay registros para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        public void MostrarCiclos(List<Ciclo> ciclos)
        {
            cmbCicloEscolar.DataSource = ciclos;
            cmbCicloEscolar.DisplayMember = "Periodo";
            cmbCicloEscolar.ValueMember = "Id";
        }

        public void ErrorMostrarCiclos(string errorCiclos)
        {
            MessageBox.Show(errorCiclos);
        }

        private void FormPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.Close();
            }
        }

        public int _CicloId
        {
            get 
            {
               Ciclo ciclo = (Ciclo)cmbCicloEscolar.SelectedItem;
               return ciclo.Id;

            }
        }

        public void MostrarConceptoPorCiclo(Concepto gConcepto)
        {
            idConcepto = gConcepto.Id;
            txtColegiaturaMensual.Text = gConcepto.Nombre;
            fkconceptoConceptoCostoCiclo = gConcepto.Id;
        }

        public void ErrorConceptoPorCiclo(string errorConceptoCiclo)
        {
            MessageBox.Show(errorConceptoCiclo);
        }

        private void cmbCicloEscolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            presentadorGrupos = new PresentadorGrupos(new SQLGrupoRepositorio(), this);
            presentadorTurnos = new PresentadorTurno(new SQLTurnoRepositorio(), this);       
            presentadorConceptoPorCiclo = new PresentadorConceptoPorCiclo(new SQLConceptoRepositorio(), this);
            presentadorCostosPorConcepto = new PresentadorCostosPorConcepto(new SQLCostoRepositorio(), this);
            presentadorMesesPorCiclo = new PresentadorMostrarMesesPorCiclo(new SQLMesRepositorio(), this);       
            if (cmbCicloEscolar.SelectedItem != null)
            {      
                presentadorConceptoPorCiclo.PresentarConceptoPorCiclo();        
                presentadorCostosPorConcepto.PresentarCostosPorConcepto();
                presentadorMesesPorCiclo.PresentarMesesPorCiclo();
                presentadorGrupos.PresentarGrupos();
                presentadorTurnos.PresentarTurnos();
           
            }
            else
                return;
        }

        public int _FkCicloMes
        {
            get 
            {
                return fkconceptoConceptoCostoCiclo;
            }
        }

        public void MostrarCostosPorConepto(IEnumerable<Costo> gCostos)
        {
            cmbCostosMensuales.DataSource = gCostos;
            cmbCostosMensuales.DisplayMember = "Precio";
            cmbCostosMensuales.ValueMember = "Id";
        }

        public void ErrorCostos(string errorCostos)
        {
            MessageBox.Show(errorCostos);
        }
        public int _Fkciclo
        {
            get 
            
            {
                Ciclo ciclo = cmbCicloEscolar.SelectedItem as Ciclo;
                if (ciclo == null)
                    MessageBox.Show("no hay ciclos ");
                return ciclo.Id;
            }
        }

        public void MostrarMesesPorCiclo(IEnumerable<Mes> meses)
        {
            cmbMeses.DataSource = meses;
            cmbMeses.DisplayMember = "Nombre";
            cmbMeses.ValueMember = "Id";
          
        }

        public void ErrorMesesPorCiclo(string error)
        {
            MessageBox.Show(error);
        }

        public int _Idciclo
        {
            get 
            {
                Ciclo ciclo = (Ciclo)cmbCicloEscolar.SelectedItem;
                if (ciclo == null)
                    MessageBox.Show("Seleccione un ciclo por favor");
                return ciclo.Id;
            
            }
        }

        public GrupoAlumnoTC GrupoalumnoTC
        {
            get { return grupoAlumnoTC; }
        }

        public void DevolverIDGrupoAlumnoTC(int idGrupoAlumnoTC)
        {
            fkidGrupoAlumnoTC = idGrupoAlumnoTC;
        }

        public void ErrorIDGrupoAlumnoTC(string errorTC)
        {
            MessageBox.Show(errorTC);
        }

        public ConceptoCostoCiclo conceptoCostoC
        {
            get { return oconceptoCostoCiclo; }
        }

        public void MostrarIdConceptoCostoCiclo(int IdC)
        {
            fkconceptoConceptoCostoCiclo = IdC;
        }

        public void ErrorConceptoCostoCiclo(string error)
        {
            MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
#region DIFERENCIA EN MESES
/*
 *         public decimal monthDiference(DateTime FechaFin, DateTime FechaInicio)
        {
            return Math.Abs((FechaFin.Month - FechaInicio.Month) + 12 * (FechaFin.Year - FechaInicio.Year));
        }
 DateTime f1 = DateTime.Parse(gCicloFecha.Inicio.ToShortDateString());
            DateTime  f2= DateTime.Parse(gCicloFecha.Fin.ToShortDateString());
            txtCiclo.Text = f1.Year + "-" + f2.Year;
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            decimal diferencia = monthDiference(gCicloFecha.Fin, gCicloFecha.Inicio);
            for (int i = 0; i < diferencia; i++)
            {
                f1 = f1.AddMonths(1);
                string mes = dtinfo.GetMonthName(f1.Month);
                cmbMeses.Items.Add(mes);
           
            }
 * */
#endregion

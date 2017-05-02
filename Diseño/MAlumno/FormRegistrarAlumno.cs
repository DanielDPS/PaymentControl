using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Datos;
using Servicio;
using MVP.Vistas;
using MVP.Presentadores;
namespace Diseño.MAlumno
{
    public partial class FormRegistrarAlumno : Form,IAgregarAlumno,/*IMostrarGrupos*/IMostrarTurnos
    {
        PresentadorAgregarAlumno presentadorAgregarAlumno;
       // private PresentadorGrupos presentadorGrupos;
        private PresentadorTurno presentadorTurnos;
        private Alumno palumno;
        public Action _Refresh;
        public FormRegistrarAlumno()
        {
            InitializeComponent();
            presentadorAgregarAlumno = new PresentadorAgregarAlumno(new SQLAlumnoRepositorio(), this );
            palumno = new Alumno();
           // presentadorGrupos = new PresentadorGrupos(new SQLGrupoRepositorio(), this);
           // presentadorGrupos.PresentarGrupos();
            presentadorTurnos = new PresentadorTurno(new SQLTurnoRepositorio(), this);
            presentadorTurnos.PresentarTurnos();
            
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtApellidos.Text == "" && txtExpediente.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                palumno.Nombre = txtNombre.Text;
                palumno.Apellidos = txtApellidos.Text;
                palumno.Expediente = int.Parse(txtExpediente.Text);
                presentadorAgregarAlumno.PresentarAgregarAlumno();
                _Refresh();
                this.Hide();
            }
                
           
           
        }

        public void Correcto(IEnumerable<Grupo> gGrupos)
        {
            cmbGrupos.DataSource = gGrupos;
            cmbGrupos.DisplayMember = "Nombre";
            cmbGrupos.ValueMember = "Id";
        }

        public void ErrorPago(string error)
        {
            MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarTurnos(IEnumerable<Turno> gTurnos)
        {
            cmbTurnos.DataSource = gTurnos;
            cmbTurnos.DisplayMember = "Nombre";
            cmbTurnos.ValueMember = "Id";
        }

        public void ErrorTurnos(string error)
        {
            MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public int idgrupo
        {
            get 
            {
                Grupo grupo = (Grupo)cmbGrupos.SelectedItem;
                return grupo.Id;
            }
        }

        public int idturno
        {
            get 
            {
                Turno turno = (Turno)cmbTurnos.SelectedItem;
                return turno.Id;
            }
        }

        public Alumno alumno
        {
            get { return palumno; }
        }

        public void AgregarAlumno(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ErrorAlumno(string errorAlumno)
        {
            MessageBox.Show(errorAlumno, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtExpediente_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) )
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtExpediente.Text.Length == 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void FormRegistrarAlumno_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if (Char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (txtNombre.Text.Length == 40)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if (Char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (txtApellidos.Text.Length == 40)
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}

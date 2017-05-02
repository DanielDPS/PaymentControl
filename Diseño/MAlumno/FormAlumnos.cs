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
using MVP.Presentadores;
using MVP.Vistas;
using System.Data;
using System.Data.SqlClient;
namespace Diseño.MAlumno
{
    public partial class FormAlumnos : Form,IMostrarAlumnos,IMostrarAlumnoPorNombreoExpediente
    {
        
        private PresentadorMostrarAlumnos presentadorAlumnos;
        private PresentadorMostrarAlumnoporNombre presentarporNombre;
        public FormAlumnos()
        {
            InitializeComponent();
            presentadorAlumnos = new PresentadorMostrarAlumnos(new SQLAlumnoRepositorio(), this);
            presentadorAlumnos.PresentarMostrarAlumnos();
            txtBusquedaAlumno.Focus();
            dgvAlumnos.Columns["Id"].Visible = false;
        }

        public void MostrarAlumnos(IEnumerable<Alumno> alumnos)
        {
            dgvAlumnos.DataSource = alumnos;
        }

        public void ErrorAlumnos(string errorAlumnos)
        {
            MessageBox.Show(errorAlumnos);
        }

        private void txtBusquedaAlumno_TextChanged(object sender, EventArgs e)
        {
            presentarporNombre = new PresentadorMostrarAlumnoporNombre(new SQLAlumnoRepositorio(), this);
            presentarporNombre.PresentarAlumnoPorNombreoExpediente();            
        }


        public string Nombrealumno
        {
            get { return txtBusquedaAlumno.Text; }
        }

        public void MostrarAlumnoporNombre(IEnumerable<Alumno> alumnos)
        {
            dgvAlumnos.DataSource = alumnos;
        }

        public void ErrorAlumnosporNombre(string errorAlumnosPorNombre)
        {
            MessageBox.Show(errorAlumnosPorNombre);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormRegistrarAlumno frmRegistroAlumno = new FormRegistrarAlumno();
            frmRegistroAlumno._Refresh = presentadorAlumnos.PresentarMostrarAlumnos;
            frmRegistroAlumno.ShowDialog();
        }

        private void dgvAlumnos_KeyDown(object sender, KeyEventArgs e)
        {
            Alumno alumnoactual = dgvAlumnos.Rows[dgvAlumnos.CurrentRow.Index].DataBoundItem as Alumno;
            if (e.KeyCode == Keys.Delete)
            {
               
                FormEliminarAlumno frmEliminar = new FormEliminarAlumno(alumnoactual);
                frmEliminar._Refresh = presentadorAlumnos.PresentarMostrarAlumnos;
                frmEliminar.ShowDialog();
            }
            else if (e.KeyCode == Keys.Space)
            {
                FormModificarAlumno frmModificar = new FormModificarAlumno(alumnoactual);
                frmModificar._Refresh = presentadorAlumnos.PresentarMostrarAlumnos;
                frmModificar.ShowDialog();

            }
        }
    }
}

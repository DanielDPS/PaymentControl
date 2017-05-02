using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diseño.MPago;
using Diseño.MAlumno;

namespace Diseño
{
    public partial class FormMenu : Form
    {
        FormLogin _Login;
        public FormMenu(FormLogin login)
        {
            InitializeComponent();
            Color color = ColorTranslator.FromHtml("#bdc3c7");
            this.BackColor = color;
            _Login = login;
            }

        private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPago frmpago = new FormPago();
            frmpago.Show();
        }

        private void moduloToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAlumnos frmAlumnos = new FormAlumnos();
            frmAlumnos.ShowDialog();
            
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Login.Close();
           
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FormPago frmpago = new FormPago();
                frmpago.Show();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                _Login.Close();
                Application.Exit();
            }
        }
    }
}

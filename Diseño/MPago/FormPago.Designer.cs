namespace Diseño.MPago
{
    partial class FormPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.lblHoraFecha = new System.Windows.Forms.Label();
            this.timerHoraYFecha = new System.Windows.Forms.Timer(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.dgvPagosRealizados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaAlumno = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCostosMensuales = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtColegiaturaMensual = new System.Windows.Forms.TextBox();
            this.cmbCicloEscolar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosRealizados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(4, 103);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(234, 21);
            this.cmbAlumnos.TabIndex = 2;
            this.cmbAlumnos.SelectedIndexChanged += new System.EventHandler(this.cmbAlumnos_SelectedIndexChanged);
            // 
            // lblHoraFecha
            // 
            this.lblHoraFecha.AutoSize = true;
            this.lblHoraFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFecha.Location = new System.Drawing.Point(6, 256);
            this.lblHoraFecha.Name = "lblHoraFecha";
            this.lblHoraFecha.Size = new System.Drawing.Size(0, 16);
            this.lblHoraFecha.TabIndex = 9;
            // 
            // timerHoraYFecha
            // 
            this.timerHoraYFecha.Enabled = true;
            this.timerHoraYFecha.Interval = 1000;
            this.timerHoraYFecha.Tick += new System.EventHandler(this.timerHoraYFecha_Tick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 134);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(229, 30);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(1072, 247);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 32);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Guardar pago";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(4, 63);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(230, 21);
            this.cmbTurnos.TabIndex = 1;
            this.cmbTurnos.SelectedIndexChanged += new System.EventHandler(this.cmbTurnos_SelectedIndexChanged);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(3, 26);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(230, 21);
            this.cmbGrupos.TabIndex = 0;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // cmbMeses
            // 
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(3, 58);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(241, 21);
            this.cmbMeses.TabIndex = 1;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.Location = new System.Drawing.Point(6, 23);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(678, 160);
            this.dgvPagos.TabIndex = 0;
            this.dgvPagos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPagos_KeyDown);
            this.dgvPagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPagos_KeyPress);
            // 
            // dgvPagosRealizados
            // 
            this.dgvPagosRealizados.AllowUserToAddRows = false;
            this.dgvPagosRealizados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            this.dgvPagosRealizados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagosRealizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosRealizados.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvPagosRealizados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosRealizados.Location = new System.Drawing.Point(7, 67);
            this.dgvPagosRealizados.Name = "dgvPagosRealizados";
            this.dgvPagosRealizados.ReadOnly = true;
            this.dgvPagosRealizados.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPagosRealizados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPagosRealizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosRealizados.Size = new System.Drawing.Size(1184, 174);
            this.dgvPagosRealizados.TabIndex = 1;
            this.dgvPagosRealizados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPagosRealizados_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPagosRealizados);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtBusquedaAlumno);
            this.groupBox4.Controls.Add(this.btnAceptar);
            this.groupBox4.Controls.Add(this.lblHoraFecha);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1196, 285);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listado de pagos registrados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Buscar por nombre o expediente";
            // 
            // txtBusquedaAlumno
            // 
            this.txtBusquedaAlumno.Location = new System.Drawing.Point(262, 37);
            this.txtBusquedaAlumno.Name = "txtBusquedaAlumno";
            this.txtBusquedaAlumno.Size = new System.Drawing.Size(928, 24);
            this.txtBusquedaAlumno.TabIndex = 0;
            this.txtBusquedaAlumno.TextChanged += new System.EventHandler(this.txtBusquedaAlumno_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvPagos);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(518, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(690, 186);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VALIDACIÓN DE PAGOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbCostosMensuales);
            this.panel1.Controls.Add(this.cmbMeses);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtColegiaturaMensual);
            this.panel1.Controls.Add(this.cmbCicloEscolar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 167);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Colegiatura mensual:";
            // 
            // cmbCostosMensuales
            // 
            this.cmbCostosMensuales.FormattingEnabled = true;
            this.cmbCostosMensuales.Location = new System.Drawing.Point(4, 138);
            this.cmbCostosMensuales.Name = "cmbCostosMensuales";
            this.cmbCostosMensuales.Size = new System.Drawing.Size(237, 21);
            this.cmbCostosMensuales.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Costos mensuales";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre:";
            // 
            // txtColegiaturaMensual
            // 
            this.txtColegiaturaMensual.Enabled = false;
            this.txtColegiaturaMensual.Location = new System.Drawing.Point(6, 98);
            this.txtColegiaturaMensual.Name = "txtColegiaturaMensual";
            this.txtColegiaturaMensual.Size = new System.Drawing.Size(237, 20);
            this.txtColegiaturaMensual.TabIndex = 2;
            // 
            // cmbCicloEscolar
            // 
            this.cmbCicloEscolar.FormattingEnabled = true;
            this.cmbCicloEscolar.Location = new System.Drawing.Point(7, 20);
            this.cmbCicloEscolar.Name = "cmbCicloEscolar";
            this.cmbCicloEscolar.Size = new System.Drawing.Size(237, 21);
            this.cmbCicloEscolar.TabIndex = 0;
            this.cmbCicloEscolar.SelectedIndexChanged += new System.EventHandler(this.cmbCicloEscolar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Seleccione el ciclo escolar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ciclo escolar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbGrupos);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.cmbAlumnos);
            this.panel2.Controls.Add(this.cmbTurnos);
            this.panel2.Location = new System.Drawing.Point(265, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 167);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Seleccione al alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Seleccione turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Seleccione el grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Modulo alumnos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 37);
            this.label11.TabIndex = 27;
            this.label11.Text = "Pagos de colegiatura";
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1217, 559);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.MaximizeBox = false;
            this.Name = "FormPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de pago";
            this.Load += new System.EventHandler(this.FormPago_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPago_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosRealizados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.Label lblHoraFecha;
        private System.Windows.Forms.Timer timerHoraYFecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridView dgvPagosRealizados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaAlumno;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCicloEscolar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColegiaturaMensual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCostosMensuales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}
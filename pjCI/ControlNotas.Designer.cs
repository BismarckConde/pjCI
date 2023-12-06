namespace pjCI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMatriculas = new System.Windows.Forms.ListView();
            this.Nombres = new System.Windows.Forms.ColumnHeader();
            this.Apellidos = new System.Windows.Forms.ColumnHeader();
            this.Asignatura = new System.Windows.Forms.ColumnHeader();
            this.Nota = new System.Windows.Forms.ColumnHeader();
            this.btnIngresarMatricula = new System.Windows.Forms.Button();
            this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
            this.btnIngresarPersona = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.lvAprobados = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnMostrarAprobadosReprobados = new System.Windows.Forms.Button();
            this.lvReprobados = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAsignaturas = new System.Windows.Forms.ComboBox();
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(4, 61);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(127, 24);
            this.txtNombres.TabIndex = 0;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(140, 61);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(127, 24);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(276, 61);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(214, 24);
            this.txtFechaNacimiento.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(27, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(960, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(771, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "CODIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(775, 61);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(127, 24);
            this.txtCodigo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "DIRECCION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(639, 61);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 24);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(500, 61);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(127, 24);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "APELLIDO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvMatriculas
            // 
            this.lvMatriculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombres,
            this.Apellidos,
            this.Asignatura,
            this.Nota});
            this.lvMatriculas.GridLines = true;
            this.lvMatriculas.Location = new System.Drawing.Point(13, 425);
            this.lvMatriculas.Margin = new System.Windows.Forms.Padding(4);
            this.lvMatriculas.Name = "lvMatriculas";
            this.lvMatriculas.Size = new System.Drawing.Size(412, 117);
            this.lvMatriculas.TabIndex = 4;
            this.lvMatriculas.UseCompatibleStateImageBehavior = false;
            this.lvMatriculas.View = System.Windows.Forms.View.Details;
            // 
            // Nombres
            // 
            this.Nombres.Text = "NOMBRE";
            this.Nombres.Width = 120;
            // 
            // Apellidos
            // 
            this.Apellidos.Text = "APELLIDO";
            this.Apellidos.Width = 120;
            // 
            // Asignatura
            // 
            this.Asignatura.Text = "ASIGNATURA";
            this.Asignatura.Width = 120;
            // 
            // Nota
            // 
            this.Nota.Text = "NOTA";
            this.Nota.Width = 50;
            // 
            // btnIngresarMatricula
            // 
            this.btnIngresarMatricula.Location = new System.Drawing.Point(631, 237);
            this.btnIngresarMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarMatricula.Name = "btnIngresarMatricula";
            this.btnIngresarMatricula.Size = new System.Drawing.Size(144, 63);
            this.btnIngresarMatricula.TabIndex = 5;
            this.btnIngresarMatricula.Text = " MATRICULA\r\n";
            this.btnIngresarMatricula.UseVisualStyleBackColor = true;
            this.btnIngresarMatricula.Click += new System.EventHandler(this.btnIngresarMatricula_Click);
            // 
            // cmbTipoPersona
            // 
            this.cmbTipoPersona.FormattingEnabled = true;
            this.cmbTipoPersona.Items.AddRange(new object[] {
            "Profesor",
            "Estudiante"});
            this.cmbTipoPersona.Location = new System.Drawing.Point(995, 63);
            this.cmbTipoPersona.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoPersona.Name = "cmbTipoPersona";
            this.cmbTipoPersona.Size = new System.Drawing.Size(130, 27);
            this.cmbTipoPersona.TabIndex = 6;
            this.cmbTipoPersona.Text = "SELECCONAR";
            // 
            // btnIngresarPersona
            // 
            this.btnIngresarPersona.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarPersona.Location = new System.Drawing.Point(995, 113);
            this.btnIngresarPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarPersona.Name = "btnIngresarPersona";
            this.btnIngresarPersona.Size = new System.Drawing.Size(131, 66);
            this.btnIngresarPersona.TabIndex = 7;
            this.btnIngresarPersona.Text = "INGRESAR PERSONA\r\n";
            this.btnIngresarPersona.UseVisualStyleBackColor = true;
            this.btnIngresarPersona.Click += new System.EventHandler(this.btnIngresarPersona_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNota);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtAsignatura);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(27, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(327, 146);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MATRICULA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "NOTA";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(149, 65);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(127, 24);
            this.txtNota.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 35);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "ASIGNATURA";
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(5, 63);
            this.txtAsignatura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(127, 24);
            this.txtAsignatura.TabIndex = 0;
            // 
            // lvAprobados
            // 
            this.lvAprobados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAprobados.GridLines = true;
            this.lvAprobados.Location = new System.Drawing.Point(469, 425);
            this.lvAprobados.Margin = new System.Windows.Forms.Padding(4);
            this.lvAprobados.Name = "lvAprobados";
            this.lvAprobados.Size = new System.Drawing.Size(413, 117);
            this.lvAprobados.TabIndex = 11;
            this.lvAprobados.UseCompatibleStateImageBehavior = false;
            this.lvAprobados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOMBRE";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "APELLIDO";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ASIGNATURA";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NOTA";
            this.columnHeader4.Width = 50;
            // 
            // btnMostrarAprobadosReprobados
            // 
            this.btnMostrarAprobadosReprobados.Location = new System.Drawing.Point(631, 308);
            this.btnMostrarAprobadosReprobados.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarAprobadosReprobados.Name = "btnMostrarAprobadosReprobados";
            this.btnMostrarAprobadosReprobados.Size = new System.Drawing.Size(144, 44);
            this.btnMostrarAprobadosReprobados.TabIndex = 12;
            this.btnMostrarAprobadosReprobados.Text = "MOSTRAR";
            this.btnMostrarAprobadosReprobados.UseVisualStyleBackColor = true;
            this.btnMostrarAprobadosReprobados.Click += new System.EventHandler(this.btnMostrarAprobadosReprobados_Click);
            // 
            // lvReprobados
            // 
            this.lvReprobados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvReprobados.GridLines = true;
            this.lvReprobados.Location = new System.Drawing.Point(246, 590);
            this.lvReprobados.Margin = new System.Windows.Forms.Padding(4);
            this.lvReprobados.Name = "lvReprobados";
            this.lvReprobados.Size = new System.Drawing.Size(418, 133);
            this.lvReprobados.TabIndex = 13;
            this.lvReprobados.UseCompatibleStateImageBehavior = false;
            this.lvReprobados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "NOMBRE";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "APELLIDO";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ASIGNATURA";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "NOTA";
            this.columnHeader8.Width = 50;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(26, 67);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(64, 19);
            this.lblEstudiante.TabIndex = 17;
            this.lblEstudiante.Text = "Nombre";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(125, 67);
            this.lblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(42, 19);
            this.lblNota.TabIndex = 18;
            this.lblNota.Text = "Nota";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(402, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "CONTROL DE NOTAS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEstudiante);
            this.groupBox3.Controls.Add(this.lblNota);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(377, 237);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(225, 127);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MEJOR PROMEDIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "MATRICULA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "APROBADOS \r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 567);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "REPROBADOS";
            // 
            // cmbAsignaturas
            // 
            this.cmbAsignaturas.FormattingEnabled = true;
            this.cmbAsignaturas.Location = new System.Drawing.Point(798, 274);
            this.cmbAsignaturas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAsignaturas.Name = "cmbAsignaturas";
            this.cmbAsignaturas.Size = new System.Drawing.Size(154, 27);
            this.cmbAsignaturas.TabIndex = 15;
            this.cmbAsignaturas.Text = "SELECCONAR";
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(798, 237);
            this.cmbEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(154, 27);
            this.cmbEstudiantes.TabIndex = 14;
            this.cmbEstudiantes.Text = "SELECCONAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 749);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbAsignaturas);
            this.Controls.Add(this.cmbEstudiantes);
            this.Controls.Add(this.lvReprobados);
            this.Controls.Add(this.btnMostrarAprobadosReprobados);
            this.Controls.Add(this.lvAprobados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIngresarPersona);
            this.Controls.Add(this.cmbTipoPersona);
            this.Controls.Add(this.btnIngresarMatricula);
            this.Controls.Add(this.lvMatriculas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtFechaNacimiento;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvMatriculas;
        private Button btnIngresarMatricula;
        private ComboBox cmbTipoPersona;
        private Button btnIngresarPersona;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtNota;
        private Label label20;
        private TextBox txtAsignatura;
        private ListView lvAprobados;
        private Button btnMostrarAprobadosReprobados;
        private ListView lvReprobados;
        private Label label7;
        private TextBox txtCodigo;
        private ColumnHeader Nombres;
        private ColumnHeader Apellidos;
        private ColumnHeader Asignatura;
        private ColumnHeader Nota;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label lblEstudiante;
        private Label lblNota;
        private Label label9;
        private GroupBox groupBox3;
        private Label label8;
        private Label label10;
        private Label label11;
        private ComboBox cmbAsignaturas;
        private ComboBox cmbEstudiantes;
    }
}

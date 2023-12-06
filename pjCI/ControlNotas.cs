namespace pjCI
{
    public partial class Form1 : Form
    {
        private List<Persona> personas = new List<Persona>();
        private List<Matricula> matriculas = new List<Matricula>();
        private Estudiante estudianteSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarMatricula_Click(object sender, EventArgs e)
        {

            string asignatura = txtAsignatura.Text;
            double nota = Convert.ToDouble(txtNota.Text);
            Estudiante estudianteSeleccionado = (Estudiante)cmbEstudiantes.SelectedItem;

            Matricula matricula = new Matricula
            {
                Asignatura = asignatura,
                Nota = nota
            };

            // Asociar la matrícula al estudiante seleccionado
            estudianteSeleccionado.Matriculas.Add(matricula);
            matriculas.Add(matricula);

            if (!cmbAsignaturas.Items.Contains(asignatura))
            {
                cmbAsignaturas.Items.Add(asignatura);
            }

            // Mostrar matrículas en lvMatriculas
            MostrarMatriculasEnListView(lvMatriculas, estudianteSeleccionado);

            // Limpiar los campos después de ingresar una matrícula
            LimpiarCampos();


        }


        private void MostrarMatriculasEnListView(ListView listView, Estudiante estudiante)
        {
            // Limpiar el ListView antes de mostrar los resultados
            listView.Items.Clear();

            // Mostrar matrículas en el ListView
            foreach (Matricula matricula in estudiante.Matriculas)
            {
                ListViewItem item = new ListViewItem(new[] { estudiante.Nombres, estudiante.Apellidos, matricula.Asignatura, matricula.Nota.ToString() });
                listView.Items.Add(item);
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            txtNombres.Clear();
            txtApellidos.Clear();
            txtFechaNacimiento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCodigo.Clear();
            txtAsignatura.Clear();
            txtNota.Clear();

            // Actualizar la lista de estudiantes en el ComboBox
            cmbEstudiantes.DataSource = null;
            cmbEstudiantes.DataSource = personas.OfType<Estudiante>().ToList();
        }

        private void btnMostrarAprobadosReprobados_Click(object sender, EventArgs e)
        {
            // Obtener la asignatura seleccionada
            string asignaturaSeleccionada = cmbAsignaturas.SelectedItem.ToString();

            // Filtrar estudiantes aprobados y reprobados por la asignatura
            var estudiantesAprobados = personas
                .OfType<Estudiante>()
                .Where(est => est.Matriculas.Any(mat => mat.Asignatura == asignaturaSeleccionada && mat.Nota >= 60))
                .ToList();

            var estudiantesReprobados = personas
                .OfType<Estudiante>()
                .Where(est => est.Matriculas.All(mat => mat.Asignatura != asignaturaSeleccionada || mat.Nota < 60))
                .ToList();

            // Mostrar resultados en controles ListView
            MostrarEstudiantesEnListView(lvAprobados, estudiantesAprobados);
            MostrarEstudiantesEnListView(lvReprobados, estudiantesReprobados);

            MostrarEstudianteConMayorPromedio();
        }

        private void MostrarEstudiantesEnListView(ListView listView, List<Estudiante> estudiantes)
        {
            // Limpiar el ListView antes de mostrar los resultados
            listView.Items.Clear();

            // Mostrar estudiantes en el ListView
            foreach (Estudiante estudiante in estudiantes)
            {
                foreach (Matricula matricula in estudiante.Matriculas)
                {
                    // Utilizar operador condicional para determinar si está aprobado o reprobado
                    string estado = (matricula.Nota >= 60) ? "Aprobado" : "Reprobado";

                    ListViewItem item = new ListViewItem(new[] { estudiante.Nombres, estudiante.Apellidos, matricula.Asignatura, matricula.Nota.ToString(), estado });
                    listView.Items.Add(item);
                }
            }
        }

        private void btnIngresarPersona_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);

            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            if (cmbTipoPersona.SelectedItem.ToString() == "Profesor")
            {
                int codigoProfesor = Convert.ToInt32(txtCodigo.Text);
                Profesor profesor = new Profesor
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaNacimiento = fechaNacimiento,
                    Direccion = direccion,
                    Telefono = telefono,
                    CodigoProfesor = codigoProfesor
                };

                personas.Add(profesor);
            }
            else if (cmbTipoPersona.SelectedItem.ToString() == "Estudiante")
            {
                int codigoEstudiante = Convert.ToInt32(txtCodigo.Text);
                Estudiante estudiante = new Estudiante
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaNacimiento = fechaNacimiento,
                    Direccion = direccion,
                    Telefono = telefono,
                    CodigoEstudiante = codigoEstudiante
                };

                personas.Add(estudiante);

                // Actualizar la lista de estudiantes en el ComboBox
                cmbEstudiantes.DataSource = null;
                cmbEstudiantes.DataSource = personas.OfType<Estudiante>().ToList();
                cmbEstudiantes.DisplayMember = "CodigoEstudiante"; // Mostrar el código del estudiante
                cmbEstudiantes.ValueMember = "CodigoEstudiante"; // Obtener el valor del código del estudiante
            }

            // Limpiar los campos después de ingresar una persona
            LimpiarCampos();
        }


        private void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar la variable estudianteSeleccionado al cambiar la selección
            estudianteSeleccionado = cmbEstudiantes.SelectedItem as Estudiante;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstudiantes.DisplayMember = "ToString";
        }


        private void MostrarEstudianteConMayorPromedio()
        {
            // Verificar si hay estudiantes
            if (personas.OfType<Estudiante>().Any())
            {
                // Calcular el promedio de notas de cada estudiante
                var promedios = personas
                    .OfType<Estudiante>()
                    .Select(est => new
                    {
                        Estudiante = est,
                        Promedio = est.Matriculas.Any() ? est.Matriculas.Average(mat => mat.Nota) : 0
                    })
                    .ToList();

                // Obtener el estudiante con el promedio más alto
                var estudianteConMayorPromedio = promedios.OrderByDescending(p => p.Promedio).FirstOrDefault();

                // Mostrar los resultados en los controles
                if (estudianteConMayorPromedio != null)
                {
                    lblEstudiante.Text = $"{estudianteConMayorPromedio.Estudiante.Nombres} {estudianteConMayorPromedio.Estudiante.Apellidos}";
                    lblNota.Text = estudianteConMayorPromedio.Promedio.ToString();
                }
                else
                {
                    lblEstudiante.Text = "No hay estudiantes con notas.";
                    lblNota.Text = string.Empty;
                }
            }
            else
            {
                lblEstudiante.Text = "No hay estudiantes registrados.";
                lblNota.Text = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

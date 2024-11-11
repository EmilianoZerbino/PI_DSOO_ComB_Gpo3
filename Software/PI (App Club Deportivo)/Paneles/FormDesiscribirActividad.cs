using PI__App_Club_Deportivo_.Entidades;
using PI__App_Club_Deportivo_.Utilidades;

namespace PI__App_Club_Deportivo_.Paneles
{
    public partial class FormDesiscribirActividad : Form
    {
        ConexionDB conexionDB;
        int dni=0;
        public FormDesiscribirActividad(ConexionDB conexionDB)
        {
            InitializeComponent();
            this.conexionDB = conexionDB;
        }


        private void FormDesiscribirActividad_Load(object sender, EventArgs e)
        {
            //tabla.Visible = false;

            tabla.Columns.Add("Actividad", "Actividad");
            tabla.Columns.Add("Arancel", "Arancel");
            tabla.Columns.Add("Profesor", "Profesor");
            tabla.Columns.Add("Horario", "Horario");

            tabla.Columns["Actividad"].Width = 130;
            tabla.Columns["Arancel"].Width = 80;
            tabla.Columns["Profesor"].Width = 170;
            tabla.Columns["Horario"].Width = 280;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            if (conexionDB.ObtenerSocioPorDni(Convert.ToInt32(txtDni.Text)) == null && conexionDB.ObtenerNoSocioPorDni(Convert.ToInt32(txtDni.Text)) == null)
            {
                MessageBox.Show("No se encontro Socio / No Socio con el DNI indicado,", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dni = Convert.ToInt32(txtDni.Text);
                List<Disciplina> disciplinas = conexionDB.consultarDisciplinasSocio(Convert.ToInt32(txtDni.Text));
                foreach (Disciplina disciplina in disciplinas)
                {
                    string horarios = "";
                    foreach (Horario horario in disciplina.Horarios)
                    {
                        horarios += horario.Dia + " de " + horario.HoraInicio.ToString("hh\\:mm") + " a " + horario.HoraFin.ToString("hh\\:mm") + "; ";
                    }
                    var index = tabla.Rows.Add(disciplina.Nombre, "$ " + disciplina.ArancelMensual, disciplina.Profesor.Nombres + " " + disciplina.Profesor.Apellidos, horarios);
                    tabla.Rows[index].Tag = disciplina.IdDisciplina;

                }
            }
        }

        private void btnDesinscribir_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = tabla.SelectedRows[0];

                // Asegúrate de que no se esté seleccionando el encabezado
                if (filaSeleccionada.Index >= 0 && filaSeleccionada.Index < tabla.Rows.Count - 1)
                {
                    // Mostrar un MessageBox de confirmación
                    DialogResult result = MessageBox.Show(
                            "¿Estás seguro de que deseas Deinscribir al Socio / No Socio con DNI " + txtDni.Text + "de " + filaSeleccionada.Cells["Actividad"].Value.ToString() + "?",
                            "Confirmar Desincripcion",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning); ;

                    if (result == DialogResult.Yes)
                    {
                        conexionDB.DesinscribirSocioActividad(Convert.ToInt32(txtDni.Text), Convert.ToInt32(filaSeleccionada.Tag));
                        MessageBox.Show("Se ha desincripto al Socio / No Socio de la Actividad", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnConsultar_Click(sender, e);
                    }
                }
                else
                {
                    // Mostrar mensaje de advertencia si se seleccionó el encabezado
                    MessageBox.Show("Seleccione una sola fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Mostrar mensaje de advertencia si no hay selección
                MessageBox.Show("Debe seleccionar una actividad antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

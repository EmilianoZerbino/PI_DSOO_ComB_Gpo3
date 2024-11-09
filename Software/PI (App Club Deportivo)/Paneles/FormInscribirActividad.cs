using PI__App_Club_Deportivo_.Entidades;
using PI__App_Club_Deportivo_.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI__App_Club_Deportivo_.Paneles
{
    public partial class FormInscribirActividad : Form
    {
        ConexionDB conexionDB;
        public FormInscribirActividad(ConexionDB conexionDB)
        {
            InitializeComponent();
            this.conexionDB = conexionDB;
        }

        private void FormInscribirActividad_Load(object sender, EventArgs e)
        {
            List<Disciplina> disciplinas = conexionDB.ObtenerListaDeDisciplinas();
            tabla.Columns.Add("Actividad", "Actividad");
            tabla.Columns.Add("Arancel", "Arancel");
            tabla.Columns.Add("Dia y Hora", "Dia Y Hora");

            tabla.Columns["Actividad"].Width = 100;
            tabla.Columns["Arancel"].Width = 100;
            tabla.Columns["Dia y Hora"].Width = 405;

            foreach (Disciplina disciplina in disciplinas)
            {
                string horarios="";
                foreach (Horario horario in disciplina.Horarios)
                {
                    horarios += horario.Dia + " de " + horario.HoraInicio.ToString("hh\\:mm") + " a " + horario.HoraFin.ToString("hh\\:mm") + "; ";
                }
                var index = tabla.Rows.Add(disciplina.Nombre, "$ " + disciplina.ArancelMensual, horarios);
                tabla.Rows[index].Tag = disciplina.IdDisciplina; 

            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y el carácter de control (como borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            // Verifica que hay una fila seleccionada y que el campo DNI no esté vacío
            if (tabla.SelectedRows.Count > 0 && txtDni.Text != "")
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = tabla.SelectedRows[0];

                // Asegúrate de que no se esté seleccionando el encabezado
                if (filaSeleccionada.Index >= 0 && filaSeleccionada.Index < tabla.Rows.Count - 1)
                {
                    // Mostrar un MessageBox de confirmación
                    DialogResult result = MessageBox.Show(
                            "¿Estás seguro de que deseas Inscribir al Socio / No Socio con DNI " + txtDni.Text + "en " + filaSeleccionada.Cells["Actividad"].Value.ToString() + "?",
                            "Confirmar Baja",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning); ;

                    // Si el usuario elige "Sí", proceder con la baja
                    if (result == DialogResult.Yes)
                    {
                        if (conexionDB.InscribirSocioActividad(Convert.ToInt32(txtDni.Text), Convert.ToInt32(filaSeleccionada.Tag)))
                        {
                            MessageBox.Show("Inscripción de Socio exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (conexionDB.InscribirNoSocioActividad(Convert.ToInt32(txtDni.Text), Convert.ToInt32(filaSeleccionada.Tag)))
                        {
                            MessageBox.Show("Inscripción de No Socio exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show("Error al Inscribir, Cheque que el DNI ingresado pertenezca a un Socio o No Socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                      }
                else
                {
                    // Mostrar mensaje de advertencia si se seleccionó el encabezado
                    MessageBox.Show("Seleccione una sola fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txtDni.Text == "")
            {
                // Mensaje si el campo DNI está vacío
                MessageBox.Show("Debe completar el campo DNI antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Mostrar mensaje de advertencia si no hay selección
                MessageBox.Show("Debe seleccionar una actividad antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

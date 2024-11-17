using PI__App_Club_Deportivo_.Utilidades;

namespace PI__App_Club_Deportivo_.Paneles
{
    public partial class FormBajaSocio : Form
    {

        ConexionDB conexionDB;
        public FormBajaSocio(ConexionDB conexionDB)
        {
            InitializeComponent();
            this.conexionDB = conexionDB;
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor, complete el campo DNI antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Mostrar un MessageBox de confirmación
                DialogResult result = MessageBox.Show(
                        "¿Estás seguro de que deseas dar de baja al Socio / No Socio con DNI " + txtDni.Text + "?",
                        "Confirmar Baja",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                // Si el usuario elige "Sí", proceder con la baja
                if (result == DialogResult.Yes)
                {
                    if (conexionDB.bajaSocio(Convert.ToInt32(txtDni.Text)))
                    {
                        MessageBox.Show("El Socio fue dado de baja correctamente.", "Baja Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (conexionDB.bajaNoSocio(Convert.ToInt32(txtDni.Text)))
                    {
                        MessageBox.Show("El NoSocio fue dado de baja correctamente.", "Baja Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el socio con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si el usuario elige "No", no se hace nada
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar) && txtDni.Text.Length >= 8)
            {
                e.Handled = true;
            }
        }
    }
}

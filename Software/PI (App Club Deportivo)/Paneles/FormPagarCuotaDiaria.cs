using PI__App_Club_Deportivo_.Utilidades;

namespace PI__App_Club_Deportivo_.Paneles
{
    public partial class FormPagarCuotaDiaria : Form
    {

        ConexionDB conexionDB;
        bool limpiar = false;
        int dni;
        double cuota;

        public FormPagarCuotaDiaria(ConexionDB conexionDB)
        {
            InitializeComponent();
            this.conexionDB = conexionDB;
            btnPagar.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals(""))
            {
                MessageBox.Show("DebeCompletar el campo DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (conexionDB.ObtenerSocioPorDni(Convert.ToInt32(txtDni.Text)) == null && conexionDB.ObtenerNoSocioPorDni(Convert.ToInt32(txtDni.Text)) == null)
            {
                MessageBox.Show("No se encontro Socio / No Socio con el DNI indicado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dni = Convert.ToInt32(txtDni.Text);
                cuota = conexionDB.consultarCuotaDiaria(Convert.ToInt32(txtDni.Text));
                btnPagar.Enabled = true;
                txtSaldo.Text = "$ " + cuota;
                limpiar = true;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (conexionDB.abonarCuotaDiaria(Convert.ToInt32(txtDni.Text)))
            {
                MessageBox.Show("La Cuota Diaria del Socio " + dni + ", se abono correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (limpiar)
            {
                txtSaldo.Text = "";
                limpiar = false;
                btnPagar.Enabled = false;
            }

            // Permitir solo números, el carácter de control (como borrar) y la coma o punto decimal.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquea la entrada
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

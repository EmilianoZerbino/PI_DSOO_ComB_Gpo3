﻿using PI__App_Club_Deportivo_.Entidades;
using PI__App_Club_Deportivo_.Utilidades;

namespace PI__App_Club_Deportivo_.Paneles
{
    public partial class FormAltaSocio : Form
    {

        ConexionDB conexionDB;
        public FormAltaSocio(ConexionDB conexionDB)
        {
            InitializeComponent();
            this.conexionDB = conexionDB;
        }
        public string Nombres { get { return txtNombres.Text; } }
        public string Apellidos { get { return txtApellidos.Text; } }
        public int Dni { get { return Convert.ToInt32(txtDni.Text); } }
        public string Nacionalidad { get { return txtNacionalidad.Text; } }

        public string Calle { get { return txtCalle.Text; } }
        public int? Altura
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtAltura.Text))
                { return null; }
                else
                {
                    return Convert.ToInt32(txtAltura.Text);
                }
            }
        }
        public int? NPiso { get {
                if (string.IsNullOrWhiteSpace(txtNPiso.Text))
                { return null; }
                else {
                    return Convert.ToInt32(txtNPiso.Text); } }
                }
        public int? NDpto
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtNDpto.Text))
                { return null; }
                else
                {
                    return Convert.ToInt32(txtNDpto.Text);
                }
            }
        }
        public string Barrio { get { return txtBarrio.Text; } }
        public string Localidad { get { return txtLocalidad.Text; } }

        public bool Socio { get { return rbSocio.Checked; } }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text) ||
                string.IsNullOrWhiteSpace(txtAltura.Text) ||
                string.IsNullOrWhiteSpace(txtBarrio.Text) ||
                string.IsNullOrWhiteSpace(txtLocalidad.Text) ||
                rbSocio.Checked == false && rbNoSocio.Checked == false)
            {
                // Mostrar mensaje de advertencia si hay algún campo vacío
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else if (cbApto.Checked == false)
            {
                // Mostrar mensaje de advertencia si no posee Apto Físico
                MessageBox.Show("No se puede dar de alta a un Socio / No Socio sin Apto físico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else {

                List<Socio> listaSocios = conexionDB.ObtenerListaDeSocios();
                List<NoSocio> listaNoSocios = conexionDB.ObtenerListaDeNoSocios();

                foreach (Socio socio in listaSocios) {
                    if (socio.Dni == Convert.ToInt32(txtDni.Text)) {
                        MessageBox.Show("Ya se encuentra un Socio registrado con ese DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.None;
                    }
                }

                foreach (NoSocio noSocio in listaNoSocios)
                {
                    if (noSocio.Dni == Convert.ToInt32(txtDni.Text))
                    {
                        MessageBox.Show("Ya se encuentra un No Socio registrado con ese DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.None;
                    }
                }
            }

        }
    }

}

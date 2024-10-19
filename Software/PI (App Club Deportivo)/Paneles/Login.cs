namespace PI__App_Club_Deportivo_.Paneles
{
    internal class Login : Label
    {
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        Button btnIngresar = new Button();
        private List<string> listaUsuarios; // Lista de usuarios válidos

        public Login(List<string> listaUsuarios, Button btnIngresar)
        {
            Width = 885;
            Height = 435;
            this.listaUsuarios = listaUsuarios;
            this.btnIngresar = btnIngresar;


            // Título
            Label titulo = new Label();
            titulo.Text = "Bienvenido a la App del Club Deportivo";
            titulo.Width = 580;
            titulo.Height = 60;
            titulo.Font = new Font("Times New Roman", 24, FontStyle.Bold);
            titulo.ForeColor = Color.Black;
            titulo.BackColor = Color.Transparent;

            // Centramos el título en el formulario
            titulo.Location = new Point((Width - titulo.Width) / 2, 50);
            Controls.Add(titulo);

            // Label Usuario
            Label lblUsuario = new Label();
            lblUsuario.Text = "Ingrese Usuario:";
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point((ClientSize.Width - lblUsuario.Width) / 2, 150);
            Controls.Add(lblUsuario);

            // TextBox Usuario
            txtUsuario = new TextBox();
            txtUsuario.Width = 300;
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Text = "Usuario";

            txtUsuario.GotFocus += new EventHandler(Usuario_RecibeFoco);
            txtUsuario.LostFocus += new EventHandler(Usuario_PierdeFoco);
            txtUsuario.TextChanged += new EventHandler(Usuario_TextoCambiado);

            txtUsuario.Location = new Point((ClientSize.Width - txtUsuario.Width) / 2, 180);
            Controls.Add(txtUsuario);

            // Label Contrasenia
            Label lblContrasenia = new Label();
            lblContrasenia.Text = "Ingrese Contraseña:";
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point((ClientSize.Width - lblContrasenia.Width) / 2, 230);
            Controls.Add(lblContrasenia);

            // TextBox Contrasenia
            txtContrasenia = new TextBox();
            txtContrasenia.Width = 300;
            txtContrasenia.ForeColor = Color.Gray;
            txtContrasenia.Text = "Contraseña";
            txtContrasenia.PasswordChar = '\0';

            txtContrasenia.GotFocus += new EventHandler(Contrasenia_RecibeFoco);
            txtContrasenia.LostFocus += new EventHandler(Contrasenia_PierdeFoco);

            txtContrasenia.Location = new Point((ClientSize.Width - txtContrasenia.Width) / 2, 260);
            Controls.Add(txtContrasenia);

            // Botón para enviar

            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Width = 100;
            this.btnIngresar.Location = new Point((ClientSize.Width - this.btnIngresar.Width) / 2, 320);
            Controls.Add(this.btnIngresar);

            // Link de Recupero de contraseña y Registro
            LinkLabel linkOlvidarContrasenia = new LinkLabel();
            linkOlvidarContrasenia.Text = "¿Olvidaste tu Contraseña?";
            linkOlvidarContrasenia.AutoSize = true;

            LinkLabel linkRegistrate = new LinkLabel();
            linkRegistrate.Text = "Registrate";
            linkRegistrate.AutoSize = true;

            linkOlvidarContrasenia.Location = new Point((ClientSize.Width - linkOlvidarContrasenia.Width - linkRegistrate.Width - 10) / 2, 360);
            linkOlvidarContrasenia.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkOlvidarContrasenia_Click);
            Controls.Add(linkOlvidarContrasenia);

            linkRegistrate.Location = new Point(linkOlvidarContrasenia.Right + 10, 360); // Coloca a la derecha del primer link
            linkRegistrate.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkRegistrate_Click);
            Controls.Add(linkRegistrate);
        }

        // Métodos para los eventos del TextBox de usuario
        private void Usuario_RecibeFoco(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void Usuario_PierdeFoco(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void Usuario_TextoCambiado(object sender, EventArgs e)
        {
            // Validar contra la lista de usuarios
            if (listaUsuarios != null && listaUsuarios.Contains(txtUsuario.Text))
            {
                txtUsuario.ForeColor = Color.Green;
            }
            else
            {
                txtUsuario.ForeColor = Color.Red;
            }
        }

        // Métodos para los eventos del TextBox de contrasenia
        private void Contrasenia_RecibeFoco(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "Contraseña")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.Black;
                txtContrasenia.PasswordChar = '*';
            }
        }

        private void Contrasenia_PierdeFoco(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                txtContrasenia.Text = "Contraseña";
                txtContrasenia.ForeColor = Color.Gray;
                txtContrasenia.PasswordChar = '\0';
            }
        }

        private void LinkOlvidarContrasenia_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Lógica para el manejo del evento de "Olvidaste tu Contraseña"
            MessageBox.Show("Funcionalidad para recuperar contraseña no implementada.", "Aviso del Sistema");
        }

        private void LinkRegistrate_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Lógica para el manejo del evento de "Regístrate"
            MessageBox.Show("Funcionalidad de registro de nuevo Usuario no implementada.", "Aviso del Sistema");
        }
    }
}


using MySql.Data.MySqlClient;
using PI__App_Club_Deportivo_.Entidades;
using PI__App_Club_Deportivo_.Paneles;
using PI__App_Club_Deportivo_.Utilidades;

namespace PI__App_Club_Deportivo_
{
    public partial class FormPrincipal : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        private MySqlConnection conexion;


        Button btnIngresar = new Button();
        Login login;
        List<Usuario> listUsuarios = new List<Usuario>();
        public FormPrincipal()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FormPrincipal_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSteelBlue;
            conexion = conexionDB.ConectarMySQL();
            listUsuarios = conexionDB.ObtenerListaDeUsuarios();
            btnIngresar.Click += new EventHandler(this.BtnIngresar_Click);
            List<string> nombreUsuarios = new List<string>();
            foreach(Usuario usuario in listUsuarios) {
                nombreUsuarios.Add(usuario.NombreUsu);
            }
            login = new Login(nombreUsuarios, btnIngresar);
            this.Controls.Add(login);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            bool checkUsuario = true;
            for (int i = 0; i < listUsuarios.Count; i++) {
                if (((TextBox)(login.Controls[2])).Text == listUsuarios[i].NombreUsu)
                {
                    if (((TextBox)(login.Controls[4])).Text == listUsuarios[i].PassUsu)
                    {
                        this.Controls.Remove(login);
                        PanelPrincipal panelPrincipal = new PanelPrincipal(conexionDB);
                        this.Controls.Add(panelPrincipal);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta. Vuelva a intentarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    checkUsuario = false;
                }
            }
            if (checkUsuario) {
                    MessageBox.Show("El Usuario no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar la aplicación?",
                "Confirmar Cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario elige "No", cancelar el cierre del formulario
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre
            }
        }
    }
}

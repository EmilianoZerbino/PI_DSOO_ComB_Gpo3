using PI__App_Club_Deportivo_.Entidades;
using PI__App_Club_Deportivo_.Utilidades;
using System.Net;

namespace PI__App_Club_Deportivo_.Paneles
{
    internal class PanelPrincipal : Label
    {
        private ConexionDB conexionDB;
        DataGridView tabla;

        public PanelPrincipal(ConexionDB conexionDB)
        {
            // Tamaño del Panel
            Width = 885;
            Height = 435;

            this.conexionDB = conexionDB;
            // Título
            Label titulo = new Label();
            titulo.Text = "Club Deportivo";
            titulo.Width = 230;
            titulo.Height = 40;
            titulo.Font = new Font("Times New Roman", 24, FontStyle.Bold);
            titulo.ForeColor = Color.Black;

            // Centramos el título en el formulario
            titulo.Location = new Point((Width - titulo.Width) / 2, 0);
            this.Controls.Add(titulo);

            // Crear botones
            Button btnMostrarSocios = new Button { Text = "Mostrar Socios / No Socios" };
            Button btnMostrarDeudores = new Button { Text = "Mostrar Deudores" };
            Button btnAltaSocio = new Button { Text = "Alta Socio / No Socio" };
            Button btnBajaSocio = new Button { Text = "Baja Socio / No Socio" };
            Button btnInscribir = new Button { Text = "Inscribir a Actividad" };
            Button btnDesInscribir = new Button { Text = "Ver Actividades Socio / Desinscribir de Actividad" };
            Button btnPagarDiaria = new Button { Text = "Pagar Cuota Diaria" };
            Button btnPagarMensual = new Button { Text = "Pagar Cuota Mensual" };

            // Agregar eventos de Click
            btnMostrarSocios.Click += BtnMostrarSocios_Click;
            btnMostrarDeudores.Click += BtnMostrarDeudores_Click;
            btnAltaSocio.Click += BtnAltaSocio_Click;
            btnBajaSocio.Click += BtnBajaSocio_Click;
            btnInscribir.Click += BtnInscribir_Click;
            btnDesInscribir.Click += BtnDesInscribir_Click;
            btnPagarDiaria.Click += BtnPagarDiaria_Click;
            btnPagarMensual.Click += BtnPagarMensual_Click;

            // Configurar el tamaño de los botones
            int botonAncho = 150;
            int botonAlto = 40;
            int desfasajeVertical = 40;
            int espacioVertical = 10;
            int espacioHorizontal = 20;
            int margenIzquierdo = 115;
            int margenSuperior = 10;

            // Posicionar botones en la primera columna
            btnMostrarSocios.SetBounds(margenIzquierdo, margenSuperior + desfasajeVertical, botonAncho, botonAlto);
            btnMostrarDeudores.SetBounds(margenIzquierdo, btnMostrarSocios.Bottom + espacioVertical, botonAncho, botonAlto);

            // Desplazar los demás botones a la derecha (segunda columna)
            btnAltaSocio.SetBounds(btnMostrarSocios.Right + espacioHorizontal, margenSuperior + desfasajeVertical, botonAncho, botonAlto);
            btnBajaSocio.SetBounds(btnAltaSocio.Left, btnAltaSocio.Bottom + espacioVertical, botonAncho, botonAlto);

            // Posicionar botones en la tercera columna
            btnInscribir.SetBounds(btnAltaSocio.Right + espacioHorizontal, margenSuperior + desfasajeVertical, botonAncho, botonAlto);
            btnDesInscribir.SetBounds(btnInscribir.Left, btnInscribir.Bottom + espacioVertical, botonAncho, botonAlto);

            // Posicionar botones en la cuarta columna
            btnPagarDiaria.SetBounds(btnInscribir.Right + espacioHorizontal, margenSuperior + desfasajeVertical, botonAncho, botonAlto);
            btnPagarMensual.SetBounds(btnPagarDiaria.Left, btnPagarDiaria.Bottom + espacioVertical, botonAncho, botonAlto);

            // Agregar botones al control
            Controls.Add(btnMostrarSocios);
            Controls.Add(btnMostrarDeudores);
            Controls.Add(btnAltaSocio);
            Controls.Add(btnBajaSocio);
            Controls.Add(btnInscribir);
            Controls.Add(btnDesInscribir);
            Controls.Add(btnPagarDiaria);
            Controls.Add(btnPagarMensual);
        }

        // Métodos de eventos Click (vacíos por ahora)
        private void BtnMostrarSocios_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(tabla);
            // Obtener la lista de socios desde la base de datos
            List<Socio> listaSocios = conexionDB.ObtenerListaDeSocios();
            List<NoSocio> listaNoSocios = conexionDB.ObtenerListaDeNoSocios();
            // Crear un nuevo DataGridView
            tabla = new DataGridView
            {
                Width = this.Width - 20, // Ajustar el ancho del DataGridView
                Height = 300, // Ajustar la altura según tus necesidades
                Location = new Point(10, 150) // Posicionar debajo de los botones
            };

            // Configurar las columnas de la tabla
            tabla.Columns.Add("Categoria", "Categoria");
            tabla.Columns.Add("Dni", "DNI");
            tabla.Columns.Add("Nombres", "Nombres");
            tabla.Columns.Add("Apellidos", "Apellidos");
            tabla.Columns.Add("Nacionalidad", "Nacionalidad");
            tabla.Columns.Add("Calle", "Calle");
            tabla.Columns.Add("Altura", "Altura");
            tabla.Columns.Add("Barrio", "Barrio");
            tabla.Columns.Add("Localidad", "Localidad");

            tabla.Columns["Categoria"].Width = 75;
            tabla.Columns["Dni"].Width = 75;
            tabla.Columns["Calle"].Width = 125;
            tabla.Columns["Altura"].Width = 50;
            

            // Llenar la tabla con los datos de la lista de socios
            foreach (var socio in listaSocios)
            {
                tabla.Rows.Add(
                    "Socio",
                    socio.Dni,
                    socio.Nombres,
                    socio.Apellidos,
                    socio.Nacionalidad,
                    socio.Direccion?.Calle,
                    socio.Direccion?.Altura,
                    socio.Direccion?.Barrio,
                    socio.Direccion?.Localidad
                    
                );
            }

            foreach (var noSocio in listaNoSocios)
            {
                tabla.Rows.Add(
                    "No Socio",
                    noSocio.Dni,
                    noSocio.Nombres,
                    noSocio.Apellidos,
                    noSocio.Nacionalidad,
                    noSocio.Direccion?.Calle,
                    noSocio.Direccion?.Altura,
                    noSocio.Direccion?.Barrio,
                    noSocio.Direccion?.Localidad
                    
                );
            }

            // Añadir el DataGridView al formulario o panel correspondiente
            this.Controls.Add(tabla);
        }

        private void BtnMostrarDeudores_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(tabla);
            // Obtener la lista de socios desde la base de datos
            List<Socio> listaSocios = conexionDB.ObtenerSociosConCuotaVencida();
            List<NoSocio> listaNoSocios = conexionDB.ObtenerNoSociosConCuotaVencida();
            // Crear un nuevo DataGridView
            tabla = new DataGridView
            {
                Width = this.Width - 355, // Ajustar el ancho del DataGridView
                Height = 300, // Ajustar la altura según tus necesidades
                Location = new Point(180, 150) // Posicionar debajo de los botones
            };

            // Configurar las columnas de la tabla
            tabla.Columns.Add("Categoria", "Categoria");
            tabla.Columns.Add("Dni", "DNI");
            tabla.Columns.Add("Nombres", "Nombres");
            tabla.Columns.Add("Apellidos", "Apellidos");
            tabla.Columns.Add("Vencimiento", "Vencimiento");

            
            
            // Llenar la tabla con los datos de la lista de socios
            foreach (var socio in listaSocios)
            {
                tabla.Rows.Add(
                    "Socio",
                    socio.Dni,
                    socio.Nombres,
                    socio.Apellidos,
                    socio.VenceCuota.Value.Day+"/"+socio.VenceCuota.Value.Month+"/"+socio.VenceCuota.Value.Year
                    
                );
            }

            foreach (var noSocio in listaNoSocios)
            {
                tabla.Rows.Add(
                    "No Socio",
                    noSocio.Dni,
                    noSocio.Nombres,
                    noSocio.Apellidos,
                    noSocio.VenceCuota.Value.Day + "/" + noSocio.VenceCuota.Value.Month + "/" + noSocio.VenceCuota.Value.Year
                );
            }

            // Añadir el DataGridView al formulario o panel correspondiente
            this.Controls.Add(tabla);
        }

        private void BtnAltaSocio_Click(object sender, EventArgs e)
        {
            FormAltaSocio formulario = new FormAltaSocio(conexionDB);
            DialogResult resultado = formulario.ShowDialog();
            DateTime hoy = DateTime.Now;
            if (resultado == DialogResult.OK)
            {
                Direccion direccion = new Direccion(formulario.Calle, formulario.Altura, formulario.NPiso, formulario.NDpto, formulario.Barrio, formulario.Localidad);

                if (formulario.Socio)
                {
                    Socio socio = new Socio(formulario.Dni, formulario.Nombres, formulario.Apellidos, direccion, formulario.Nacionalidad, hoy);
                    conexionDB.InsertarSocio(socio);
                    MessageBox.Show("Se ha dado de alta correctamente al Socio con DNI: " + formulario.Dni, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Se le entregará el carnet con el numero de Socio: " + formulario.Dni, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NoSocio noSocio = new NoSocio(formulario.Dni, formulario.Nombres, formulario.Apellidos, direccion, formulario.Nacionalidad, hoy);
                    conexionDB.InsertarNoSocio(noSocio);
                    MessageBox.Show("Se ha dado de alta correctamente al No Socio con DNI: " + formulario.Dni, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void BtnBajaSocio_Click(object sender, EventArgs e)
        {
            FormBajaSocio formulario = new FormBajaSocio(conexionDB);
            DialogResult resultado = formulario.ShowDialog();
        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            FormInscribirActividad formulario = new FormInscribirActividad(conexionDB);
            formulario.ShowDialog();
        }

        private void BtnDesInscribir_Click(object sender, EventArgs e)
        {
            FormDesiscribirActividad formulario = new FormDesiscribirActividad(conexionDB);
            formulario.ShowDialog();
        }

        private void BtnPagarDiaria_Click(object sender, EventArgs e)
        {
            FormPagarCuotaDiaria formulario = new FormPagarCuotaDiaria(conexionDB);
            formulario.ShowDialog();
        }

        private void BtnPagarMensual_Click(object sender, EventArgs e)
        {
            FormPagarCuotaMensual formulario = new FormPagarCuotaMensual(conexionDB);
            formulario.ShowDialog();
        }
    }
}

using MySql.Data.MySqlClient;
using PI__App_Club_Deportivo_.Entidades;
using static Mysqlx.Crud.Order.Types;
using System.Net;
using System.Data;
using System.Transactions;

namespace PI__App_Club_Deportivo_.Utilidades
{
    public class ConexionDB
    {
        private MySqlConnection conexion;
        public MySqlConnection ConectarMySQL()
        {
            // Cadena de conexión
            string servidor = "localhost"; // o la IP del servidor MySQL
            string bd = "clubdeportivo";
            string usuario = "root"; //Aca va el usuario del dueño de la Base de Datos, Varia de Compu a Compu
            string password = "12345678"; //Aca va la contraseña del dueño de la Base de Datos, Varia de Compu a Compu
            string cadenaConexion = $"Server={servidor};Database={bd};Uid={usuario};Pwd={password};";

            try
            {
                // Crear la conexión
                conexion = new MySqlConnection(cadenaConexion);
                //conexion.Open(); // Abre la conexión

                //MessageBox.Show("Conexión exitosa a MySQL");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar a MySQL: {ex.Message}");
            }
            return conexion;
        }

        public List<Usuario> ObtenerListaDeUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string consulta = "SELECT CodUsu,NombreUsu,PassUsu,RolUsu,Activo FROM usuario";

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                // Leer los resultados y agregar cada usuario a la lista
                while (lector.Read())
                {
                    // Crear un objeto Usuario y añadirlo a la lista
                    Usuario usuario = new Usuario
                    {
                        CodUsu = lector.GetInt32("CodUsu"),
                        NombreUsu = lector.GetString("NombreUsu"),
                        PassUsu = lector.GetString("PassUsu"),
                        RolUsu = lector.GetInt32("RolUsu"),
                        Activo = lector.GetBoolean("Activo")
                    };
                    listaUsuarios.Add(usuario);
                }

                lector.Close(); // Cerrar el lector cuando termines
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
            return listaUsuarios;
        }

        public List<Socio> ObtenerListaDeSocios()
        {
            List<Socio> listaSocios = new List<Socio>();
            string consulta = @"
        SELECT 
            s.IdSocio, s.Dni, s.Nombres, s.Apellidos, s.Nacionalidad,
            d.Calle, d.Altura, d.NPiso, d.NDepto, d.Barrio, d.Localidad 
        FROM socio s
        LEFT JOIN direccion d ON s.IdDireccion = d.IdDireccion";


            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Direccion direccion = new Direccion(
                        lector.GetString("Calle"),
                        lector.GetInt32("Altura"),
                        lector.IsDBNull("NPiso") ? null : (int?)lector.GetInt32("NPiso"),
                        lector.IsDBNull("NDepto") ? null : (int?)lector.GetInt32("NDepto"),
                        lector.GetString("Barrio"),
                        lector.GetString("Localidad")
                    );


                    Socio socio = new Socio(
                        lector.GetInt32("Dni"),
                        lector.GetString("Nombres"),
                        lector.GetString("Apellidos"),
                        direccion,
                        lector.GetString("Nacionalidad"),
                        null
                    );

                    listaSocios.Add(socio);
                }

                lector.Close(); // Cerrar el lector cuando termines
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
            return listaSocios;
        }

        public List<NoSocio> ObtenerListaDeNoSocios()
        {
            List<NoSocio> listaNoSocios = new List<NoSocio>();
            string consulta = @"
        SELECT 
            s.IdNoSocio, s.Dni, s.Nombres, s.Apellidos, s.Nacionalidad,
            d.Calle, d.Altura, d.NPiso, d.NDepto, d.Barrio, d.Localidad 
        FROM noSocio s
        LEFT JOIN direccion d ON s.IdDireccion = d.IdDireccion";


            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Direccion direccion = new Direccion(
                        lector.GetString("Calle"),
                        lector.GetInt32("Altura"),
                        lector.IsDBNull("NPiso") ? null : (int?)lector.GetInt32("NPiso"),
                        lector.IsDBNull("NDepto") ? null : (int?)lector.GetInt32("NDepto"),
                        lector.GetString("Barrio"),
                        lector.GetString("Localidad")
                    );


                    NoSocio noSocio = new NoSocio(
                        lector.GetInt32("Dni"),
                        lector.GetString("Nombres"),
                        lector.GetString("Apellidos"),
                        direccion,
                        lector.GetString("Nacionalidad"),
                        null

                    );

                    listaNoSocios.Add(noSocio);
                }

                lector.Close(); // Cerrar el lector cuando termines
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
            return listaNoSocios;
        }

        public List<Socio> ObtenerSociosConCuotaVencida()
        {
            List<Socio> listaSocios = new List<Socio>();
            string consulta = "SELECT Dni, Nombres, Apellidos, venceCuota FROM socio WHERE venceCuota < CURDATE()"; // Filtra por cuota vencida

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Socio socio = new Socio(
                        lector.GetInt32("Dni"),
                        lector.GetString("Nombres"),
                        lector.GetString("Apellidos"),
                        null, null,
                        lector.GetDateTime("venceCuota") // Obtiene la fecha de vencimiento de cuota
                    );

                    listaSocios.Add(socio);
                }

                lector.Close(); // Cerrar el lector cuando termines
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
            return listaSocios;
        }

        public List<NoSocio> ObtenerNoSociosConCuotaVencida()
        {
            List<NoSocio> listaNoSocios = new List<NoSocio>();
            string consulta = "SELECT Dni, Nombres, Apellidos, venceCuota FROM noSocio WHERE venceCuota < CURDATE()"; // Filtra por cuota vencida

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    NoSocio noSocio = new NoSocio(
                        lector.GetInt32("Dni"),
                        lector.GetString("Nombres"),
                        lector.GetString("Apellidos"),
                        null, null,
                        lector.GetDateTime("venceCuota") // Obtiene la fecha de vencimiento de cuota
                    );

                    listaNoSocios.Add(noSocio);
                }

                lector.Close(); // Cerrar el lector cuando termines
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
            return listaNoSocios;
        }

        public void InsertarSocio(Socio socio)
        {
            conexion.Open();

            // Iniciar una transacción para asegurarte de que ambas inserciones se realicen correctamente
            MySqlTransaction transaction = conexion.BeginTransaction();

            try
            {
                // Insertar en la tabla direccion
                string insertDireccionQuery = @"
                INSERT INTO direccion (calle, altura, NPiso, NDepto, Barrio, Localidad)
                VALUES (@calle, @altura, @NPiso, @NDepto, @Barrio, @Localidad);
                SELECT LAST_INSERT_ID();";

                MySqlCommand direccionCmd = new MySqlCommand(insertDireccionQuery, conexion, transaction);
                direccionCmd.Parameters.AddWithValue("@calle", socio.Direccion.Calle);
                direccionCmd.Parameters.AddWithValue("@altura", socio.Direccion.Altura);
                direccionCmd.Parameters.AddWithValue("@NPiso", socio.Direccion.NPiso);
                direccionCmd.Parameters.AddWithValue("@NDepto", socio.Direccion.NDepto);
                direccionCmd.Parameters.AddWithValue("@Barrio", socio.Direccion.Barrio);
                direccionCmd.Parameters.AddWithValue("@Localidad", socio.Direccion.Localidad);

                // Obtener el IdDireccion generado automáticamente
                int idDireccion = Convert.ToInt32(direccionCmd.ExecuteScalar());

                // Insertar en la tabla socio
                string insertSocioQuery = @"
                INSERT INTO socio (IdDireccion, Dni, Nombres, Apellidos, Nacionalidad, venceCuota)
                VALUES (@IdDireccion, @Dni, @Nombres, @Apellidos, @Nacionalidad, @VenceCuota);";

                MySqlCommand socioCmd = new MySqlCommand(insertSocioQuery, conexion, transaction);
                socioCmd.Parameters.AddWithValue("@IdDireccion", idDireccion);
                socioCmd.Parameters.AddWithValue("@Dni", socio.Dni);
                socioCmd.Parameters.AddWithValue("@Nombres", socio.Nombres);
                socioCmd.Parameters.AddWithValue("@Apellidos", socio.Apellidos);
                socioCmd.Parameters.AddWithValue("@Nacionalidad", socio.Nacionalidad);
                socioCmd.Parameters.AddWithValue("@VenceCuota", socio.VenceCuota);

                // Ejecutar la inserción del socio
                socioCmd.ExecuteNonQuery();

                // Confirmar la transacción
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // Si ocurre un error, revertir la transacción
                transaction.Rollback();
                throw new Exception("Error al insertar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void InsertarNoSocio(NoSocio noSocio)
        {
            conexion.Open();

            // Iniciar una transacción para asegurarte de que ambas inserciones se realicen correctamente
            MySqlTransaction transaction = conexion.BeginTransaction();

            try
            {
                // Insertar en la tabla direccion
                string insertDireccionQuery = @"
                INSERT INTO direccion (calle, altura, NPiso, NDepto, Barrio, Localidad)
                VALUES (@calle, @altura, @NPiso, @NDepto, @Barrio, @Localidad);
                SELECT LAST_INSERT_ID();";

                MySqlCommand direccionCmd = new MySqlCommand(insertDireccionQuery, conexion, transaction);
                direccionCmd.Parameters.AddWithValue("@calle", noSocio.Direccion.Calle);
                direccionCmd.Parameters.AddWithValue("@altura", noSocio.Direccion.Altura);
                direccionCmd.Parameters.AddWithValue("@NPiso", noSocio.Direccion.NPiso);
                direccionCmd.Parameters.AddWithValue("@NDepto", noSocio.Direccion.NDepto);
                direccionCmd.Parameters.AddWithValue("@Barrio", noSocio.Direccion.Barrio);
                direccionCmd.Parameters.AddWithValue("@Localidad", noSocio.Direccion.Localidad);

                // Obtener el IdDireccion generado automáticamente
                int idDireccion = Convert.ToInt32(direccionCmd.ExecuteScalar());

                // Insertar en la tabla noocio
                string insertNoSocioQuery = @"
                INSERT INTO NoSocio (IdDireccion, Dni, Nombres, Apellidos, Nacionalidad, venceCuota)
                VALUES (@IdDireccion, @Dni, @Nombres, @Apellidos, @Nacionalidad, @VenceCuota);";

                MySqlCommand noSocioCmd = new MySqlCommand(insertNoSocioQuery, conexion, transaction);
                noSocioCmd.Parameters.AddWithValue("@IdDireccion", idDireccion);
                noSocioCmd.Parameters.AddWithValue("@Dni", noSocio.Dni);
                noSocioCmd.Parameters.AddWithValue("@Nombres", noSocio.Nombres);
                noSocioCmd.Parameters.AddWithValue("@Apellidos", noSocio.Apellidos);
                noSocioCmd.Parameters.AddWithValue("@Nacionalidad", noSocio.Nacionalidad);
                noSocioCmd.Parameters.AddWithValue("@VenceCuota", noSocio.VenceCuota);

                // Ejecutar la inserción del socio
                noSocioCmd.ExecuteNonQuery();

                // Confirmar la transacción
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // Si ocurre un error, revertir la transacción
                transaction.Rollback();
                throw new Exception("Error al insertar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        
        public bool bajaSocio(int dni)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("EliminarSocioPorDNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d", dni);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool bajaNoSocio(int dni)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("EliminarNoSocioPorDNI", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d", dni);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool InscribirSocioActividad(int dni, int idDisciplina)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("InscribirSocioActividad", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d", dni);
                cmd.Parameters.AddWithValue("@idD", idDisciplina);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool InscribirNoSocioActividad(int dni, int idDisciplina)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("InscribirNoSocioActividad", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d", dni);
                cmd.Parameters.AddWithValue("@idD", idDisciplina);

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Disciplina> ObtenerListaDeDisciplinas()
        {
            List<Disciplina> listaDisciplinas = new List<Disciplina>();
            string consulta = @"
                        SELECT * from disciplina d join Profesor p
                        On d.IdProfesor = p.IdProfesor join 
                        direccion di on p.IdDireccion = di.IdDireccion";

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    // Obtener la dirección del profesor
                    Direccion direccion = new Direccion(
                        lector.GetString("Calle"),
                        lector.GetInt32("Altura"),
                        lector.IsDBNull("NPiso") ? null : (int?)lector.GetInt32("NPiso"),
                        lector.IsDBNull("NDepto") ? null : (int?)lector.GetInt32("NDepto"),
                        lector.GetString("Barrio"),
                        lector.GetString("Localidad")
                    );

                    // Crear el profesor
                    Profesor profesor = new Profesor(
                        lector.GetInt32("Dni"),
                        lector.GetString("Nombres"),
                        lector.GetString("Apellidos"),
                        direccion,
                        lector.GetString("Nacionalidad"),
                        lector.GetInt32("NMatricula")
                    );

                    // Crear la disciplina
                    Disciplina disciplina = new Disciplina(
                        lector.GetInt32("IdDisciplina"),
                        lector.GetString("Nombre"),
                        profesor,
                        lector.GetInt32("MaxInscriptos"),
                        new List<Horario>(),
                        lector.GetDouble("ArancelMensual")
                    );
                    listaDisciplinas.Add(disciplina);
                }

                lector.Close(); // Cerrar el lector principal
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }

            consulta = @"select * from horario";
            List<Horario> horarios = new List<Horario>();

            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Horario horario = new Horario(
                        lector.GetInt32("IdDisciplina"),
                        (DiaSemana)Enum.Parse(typeof(DiaSemana), lector.GetString("Dia")),
                        lector.GetTimeSpan("HoraInicio"),
                        lector.GetTimeSpan("HoraFin")
                    );
                    horarios.Add(horario);
                }

                lector.Close(); // Cerrar el lector principal
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }

            foreach (Disciplina disciplina in listaDisciplinas) {
                foreach (Horario horario in horarios) {
                    if (disciplina.IdDisciplina == horario.IdDisciplina) { 
                    disciplina.Horarios.Add(horario);
                    }
                }
            }

            return listaDisciplinas;
        }

    }
}

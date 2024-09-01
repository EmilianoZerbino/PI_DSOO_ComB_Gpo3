namespace PI_DSOO_ComB_Gpo3.Clases
{
    internal class Persona
    {
        public int Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Direccion Direccion { get; set; }
        public string Nacionalidad { get; set; }

        public Persona(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad)
        {

            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Nacionalidad = nacionalidad;

        }

    }
    internal class Direccion
    {

        public string Calle { get; set; }
        public string[] EntreCalles { get; set; }
        public int Altura { get; set; }

        public Int32 NPiso { get; set; }
        public Int32 NDepto { get; set; }

        public String Barrio { get; set; }
        public String Localidad { get; set; }

    }
}

namespace PI_DSOO_ComB_Gpo3
{
    internal abstract class Persona //Aca la declaramos abstracta porque solo la vamos a usar como superclase para una serie de subtipos heredados y no queremos que sea posible instanciarla.

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
        public int Altura { get; set; }
        public int? NPiso { get; set; } //El signo de pregunta es para que acepte valores null
        public int? NDepto { get; set; } //El signo de pregunta es para que acepte valores null
        public String Barrio { get; set; }
        public string Localidad { get; set; }

        public Direccion(string calle, int altura, int? nPiso, int? nDepto, String barrio, string localidad) { 
            
            Calle=calle;
            Altura=altura;
            NPiso=nPiso;
            NDepto=nDepto;
            Barrio=barrio;
            Localidad=localidad;
         
        }
    }
}

namespace PI__App_Club_Deportivo_.Entidades
{
    public abstract class Persona //Aca la declaramos abstracta porque solo la vamos a usar como superclase para una serie de subtipos heredados y no queremos que sea posible instanciarla.
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
    public class Direccion
    {

        public string Calle { get; set; }
        public int Altura { get; set; }
        public int? NPiso { get; set; } //El signo de pregunta es para que acepte valores null
        public int? NDepto { get; set; } //El signo de pregunta es para que acepte valores null
        public string Barrio { get; set; }
        public string Localidad { get; set; }

        public Direccion(string calle, int altura, int? nPiso, int? nDepto, string barrio, string localidad)
        {

            Calle = calle;
            Altura = altura;
            NPiso = nPiso;
            NDepto = nDepto;
            Barrio = barrio;
            Localidad = localidad;

        }
    }
}

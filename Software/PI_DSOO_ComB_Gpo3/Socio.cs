namespace PI_DSOO_ComB_Gpo3
{
    internal class Socio : Persona
    {

        private static int siguienteNumeroSocio = 1;
        public int NSocio { get; set; }
        public List<Disciplina> Actividades { get; set; }
        public Socio(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad)
             : base(dni, nombres, apellidos, direccion, nacionalidad)
        {
            NSocio = siguienteNumeroSocio;
            siguienteNumeroSocio++;
            Actividades = new List<Disciplina>();
        }

    }
}

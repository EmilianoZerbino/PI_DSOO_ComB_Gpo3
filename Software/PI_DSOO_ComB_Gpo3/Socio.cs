namespace PI_DSOO_ComB_Gpo3
{
    internal class Socio : Persona
    {

        public int NSocio { get; set; }
        public List<Disciplina> Actividades { get; set; }
        public Socio(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad, int nSocio)
             : base(dni, nombres, apellidos, direccion, nacionalidad)
        {
            NSocio = nSocio;
            Actividades = new List<Disciplina>();
        }

    }
}

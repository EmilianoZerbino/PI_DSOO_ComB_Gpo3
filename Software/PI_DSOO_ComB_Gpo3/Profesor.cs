namespace PI_DSOO_ComB_Gpo3
{
    internal class Profesor : Persona
    {

        public int NMatricula { get; set; }
        public Profesor(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad, int nMatricula)
             : base(dni, nombres, apellidos, direccion, nacionalidad)
        {
            NMatricula = nMatricula;
        }

    }
}

namespace PI__App_Club_Deportivo_.Entidades
{
    public class Profesor : Persona
    {
        public int IdProfesor {  get; set; }
        public int NMatricula { get; set; }
        public Profesor(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad, int nMatricula)
             : base(dni, nombres, apellidos, direccion, nacionalidad)
        {
            NMatricula = nMatricula;
        }

    }
}

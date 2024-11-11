namespace PI__App_Club_Deportivo_.Entidades
{
    public class NoSocio : Persona
    {

        public List<Disciplina> Actividades { get; set; }
        public DateTime? VenceCuota { get; set; }

        public NoSocio(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad, DateTime? venceCuota)
             : base(dni, nombres, apellidos, direccion, nacionalidad)
        {
            Actividades = new List<Disciplina>();
            VenceCuota = venceCuota;
        }

    }
}

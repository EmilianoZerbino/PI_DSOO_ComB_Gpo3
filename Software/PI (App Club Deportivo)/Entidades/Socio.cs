using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI__App_Club_Deportivo_.Entidades
{
    public class Socio : Persona
    {
        public int NSocio { get; set; }
        public DateTime? VenceCuota { get; set; }
        public List<Disciplina> Actividades { get; set; }
        public Socio(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad, DateTime? venceCuota)
             : base(dni, nombres, apellidos, direccion, nacionalidad)
        {
            Actividades = new List<Disciplina>();
            VenceCuota = venceCuota;
        }

    }
}

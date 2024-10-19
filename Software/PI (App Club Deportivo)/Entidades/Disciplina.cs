using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI__App_Club_Deportivo_.Entidades
{
    public class Disciplina
    {
        public string Nombre { get; set; }
        public Horario Horario { get; set; }
        public double ArancelMensual { get; set; }
        public Profesor Profesor { get; set; }

        public int MaxInscriptos { get; set; }
        public List<Socio> Inscriptos { get; set; }

        public Disciplina(string nombre, Profesor profesor, int maxInscriptos, Horario horario, double arancelMensual)
        {

            Inscriptos = new List<Socio>();
            Nombre = nombre;
            Profesor = profesor;
            MaxInscriptos = maxInscriptos;
            Horario = horario;
            ArancelMensual = arancelMensual;


        }
    }

    public class Horario
    {
        public DayOfWeek[] Dias { get; set; }
        public TimeSpan[] HoraInicio { get; set; }
        public TimeSpan[] HoraFin { get; set; }

        public Horario(DayOfWeek[] dias, TimeSpan[] horaInicio, TimeSpan[] horaFin)
        {
            Dias = dias;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}

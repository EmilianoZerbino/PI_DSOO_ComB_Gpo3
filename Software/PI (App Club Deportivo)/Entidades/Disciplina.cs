using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI__App_Club_Deportivo_.Entidades
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public string Nombre { get; set; }
        public List<Horario> Horarios { get; set; }
        public double ArancelMensual { get; set; }
        public Profesor Profesor { get; set; }

        public int MaxInscriptos { get; set; }
        public List<Socio> Inscriptos { get; set; }

        public Disciplina(int id, string nombre, Profesor profesor, int maxInscriptos, List<Horario> horarios, double arancelMensual)
        {
            IdDisciplina = id;
            Inscriptos = new List<Socio>();
            Nombre = nombre;
            Profesor = profesor;
            MaxInscriptos = maxInscriptos;
            Horarios = horarios;
            ArancelMensual = arancelMensual;


        }
    }

    public class Horario
    {
        public int IdDisciplina { get; set;}
        public DiaSemana Dia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public Horario(int idDisciplina, DiaSemana dia, TimeSpan horaInicio, TimeSpan horaFin)
        {
            IdDisciplina= idDisciplina;
            Dia = dia;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }

    public enum DiaSemana
    {
        Domingo,
        Lunes,
        Martes,
        Miércoles,
        Jueves,
        Viernes,
        Sábado
    }
}

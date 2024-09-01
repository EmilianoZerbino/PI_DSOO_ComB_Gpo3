namespace PI_DSOO_ComB_Gpo3.Clases
{
    internal class Disciplina
    {
        public string Nombre { get; set; }
        public Horario Horario { get; set; }
        public double ArancelMensual { get; set; }

        public Disciplina(string nombre, Horario horario, double arancelMensual) {
        
            Nombre = nombre;
            Horario = horario;
            ArancelMensual = arancelMensual;
        }
    }

    internal class Horario
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

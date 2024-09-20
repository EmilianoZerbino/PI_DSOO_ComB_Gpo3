namespace PI_DSOO_ComB_Gpo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creación del Club Deportivo

            ClubDeportivo clubDeportivo = new ClubDeportivo();

            //Alta de Profes

            clubDeportivo.Profesores.Add(new Profesor(21111111, "Diego Armando", "Maradona", new Direccion("Calle Florida"   , 456, 1   , 2   , "Microcentro", "C.A.B.A."), "Argentina", 111));
            clubDeportivo.Profesores.Add(new Profesor(12222222, "Gabriela"     , "Sabatini", new Direccion("Calle Corrientes", 789, null, null, "Almagro"    , "C.A.B.A."), "Argentina", 112));
            clubDeportivo.Profesores.Add(new Profesor(13333333, "Ricardo"      , "Darin"   , new Direccion("Calle Lavalle"   , 321, 2   , null, null         , "La Plata"), "Argentina", 113));
            clubDeportivo.Profesores.Add(new Profesor(14444444, "Manuel"       , "Ginobili", new Direccion("Av. Santa Fe"    , 654, 7   , 8   , "Palermo"    , "C.A.B.A."), "Argentina", 114));
            clubDeportivo.Profesores.Add(new Profesor(15555555, "Mercedes"     , "Sosa"    , new Direccion("Calle Arenales"  , 987, null, null, null         , "Lanus"   ), "Argentina", 115));

            //Alta de Disciplinas

            clubDeportivo.Disciplinas.Add(new Disciplina("Futbol"  , clubDeportivo.Profesores[0], 25, new Horario(new DayOfWeek[] { DayOfWeek.Monday   , DayOfWeek.Wednesday, DayOfWeek.Friday }, new TimeSpan[] { new TimeSpan(9 , 0, 0), new TimeSpan(14, 0, 0), new TimeSpan(18, 0, 0) }, new TimeSpan[] { new TimeSpan(11, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(20, 0, 0) }), 5600));
            clubDeportivo.Disciplinas.Add(new Disciplina("Tenis"   , clubDeportivo.Profesores[1], 15, new Horario(new DayOfWeek[] { DayOfWeek.Tuesday  , DayOfWeek.Thursday                    }, new TimeSpan[] { new TimeSpan(8 , 0, 0), new TimeSpan(13, 0, 0)                         }, new TimeSpan[] { new TimeSpan(10, 0, 0), new TimeSpan(15, 0, 0)                         }), 4700));
            clubDeportivo.Disciplinas.Add(new Disciplina("Natación", clubDeportivo.Profesores[2], 30, new Horario(new DayOfWeek[] { DayOfWeek.Monday   , DayOfWeek.Friday                      }, new TimeSpan[] { new TimeSpan(7 , 0, 0), new TimeSpan(17, 0, 0)                         }, new TimeSpan[] { new TimeSpan(9 , 0, 0), new TimeSpan(19, 0, 0)                         }), 5200));
            clubDeportivo.Disciplinas.Add(new Disciplina("Basquet" , clubDeportivo.Profesores[3], 20, new Horario(new DayOfWeek[] { DayOfWeek.Wednesday, DayOfWeek.Saturday                    }, new TimeSpan[] { new TimeSpan(10, 0, 0), new TimeSpan(18, 0, 0)                         }, new TimeSpan[] { new TimeSpan(12, 0, 0), new TimeSpan(20, 0, 0)                         }), 6100));
            clubDeportivo.Disciplinas.Add(new Disciplina("Voleibol", clubDeportivo.Profesores[4], 3, new Horario(new DayOfWeek[] { DayOfWeek.Tuesday  , DayOfWeek.Thursday                    }, new TimeSpan[] { new TimeSpan(11, 0, 0), new TimeSpan(15, 0, 0)                         }, new TimeSpan[] { new TimeSpan(13, 0, 0), new TimeSpan(17, 0, 0)                         }), 4900));

            //Alta Socios (a traves del método altaSocios)

            clubDeportivo.altaSocio(21111111, "Juan Cruz"     , "Merino"         , new Direccion("Calle Florida" , 456, 1, 2 , "Microcentro"     , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(22222222, "Ana"           , "Gonzalez Garcia", new Direccion("Av. Corrientes", 789, 5, 6 , "Almagro"         , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(23333333, "Luis Alberto"  , "Fernandez"      , new Direccion("Calle Lavalle" , 321, 2, 3 , "San Telmo"       , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(24444444, "Marta Agustina", "Lopez Conrado"  , new Direccion("Av. Santa Fe"  , 654, 7, 8 , "Palermo"         , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(25555555, "Carlos"        , "Ruiz"           , new Direccion("Calle Arenales", 987, 9, 10, "Recoleta"        , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(26666666, "Valeria Estela", "Morales"        , new Direccion("Calle Tucumán" , 123, 4, 5 , "Congreso"        , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(27777777, "Santiago"      , "Gómez"          , new Direccion("Av. Belgrano"  , 456, 3, 6 , "Monserrat"       , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(28888888, "Lucía"         , "Martínez"       , new Direccion("Calle Córdoba" , 789, 1, 2 , "Retiro"          , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(29999999, "Roberto"       , "Cruz"           , new Direccion("Calle Jujuy"   , 101, 6, 7 , "Villa Urquiza"   , "C.A.B.A."), "Argentina");
            clubDeportivo.altaSocio(20000000, "Paola"         , "Vázquez"        , new Direccion("Av. Rivadavia" , 202, 8, 9 , "Villa del Parque", "C.A.B.A."), "Argentina");

            //Prueba del método inscribirActividad

            Console.WriteLine(clubDeportivo.inscribirActividad("Futbol"  , 1));
            Console.WriteLine(clubDeportivo.inscribirActividad("Futbol"  , 1));  //YA INSCRIPTO
            Console.WriteLine(clubDeportivo.inscribirActividad("Natación", 1));
            Console.WriteLine(clubDeportivo.inscribirActividad("Paddle"  , 1));  //ACTIVIDAD INEXISTENTE
            Console.WriteLine(clubDeportivo.inscribirActividad("Basquet" , 1));
            Console.WriteLine(clubDeportivo.inscribirActividad("Tenis"   , 1));  //TOPE DE ACTIVIDADES ALCANZADO

            Console.WriteLine(clubDeportivo.inscribirActividad("Tenis"   , 15)); //SOCIO INEXISTENTE

            Console.WriteLine(clubDeportivo.inscribirActividad("Voleibol", 2)); 
            Console.WriteLine(clubDeportivo.inscribirActividad("Voleibol", 3)); 
            Console.WriteLine(clubDeportivo.inscribirActividad("Voleibol", 4)); 
            Console.WriteLine(clubDeportivo.inscribirActividad("Voleibol", 5));  //TOPE DE CUPOS ALCANZADO
        }
    }
}

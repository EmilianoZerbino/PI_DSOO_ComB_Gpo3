namespace PI_DSOO_ComB_Gpo3
{
    internal class ClubDeportivo
    {

        public List<Socio> Socios { get; } //Aca se le saco el Set para forzar a que las altas se hagan a traves del metodo altaSocio

        public static int siguienteNumeroSocio = 1;
        public List<Profesor> Profesores { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public ClubDeportivo() {

            Profesores = new List<Profesor>();
            Disciplinas = new List<Disciplina>();
            Socios = new List<Socio>();
            
        }

        public void altaSocio(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad) {
            Socio socio = new Socio(dni, nombres, apellidos, direccion, nacionalidad, siguienteNumeroSocio);
            siguienteNumeroSocio++;
            Socios.Add(socio);
        }

        public string inscribirActividad(string nombreDisciplina, int nSocio) {
            string respuesta = "";
            Disciplina actividad = null;
            foreach (Disciplina disciplina in Disciplinas) {
                if (disciplina.Nombre.Equals(nombreDisciplina)) { 
                    actividad = disciplina;
                }
            }
            Socio postulante = null;
            foreach (Socio socio in Socios) {
                if (socio.NSocio == nSocio) { 
                    postulante = socio;
                }
            }
            if (postulante != null &&
                actividad != null )
            {
                if (actividad.Inscriptos.Count < actividad.MaxInscriptos && //Nos parecio correcto que tambien se evalue la cantidad de miembros que puede participar en cada actividad
                    postulante.Actividades.Count < 3) {
                    bool bandera = true;
                    foreach (Disciplina act in postulante.Actividades) {
                        if (act.Nombre.Equals(nombreDisciplina)) { //Evalua que ya no este inscripto en la actividad
                            respuesta = "YA SE ENCUENTRA INSCRIPTO";
                            bandera = false;
                        }
                    }
                    if(bandera)
                    {
                        actividad.Inscriptos.Add(postulante);
                        postulante.Actividades.Add(actividad);
                        respuesta = "INSCRIPCIÓN EXITOSA";
                    }
                }
                else if (postulante.Actividades.Count >= 3)
                {
                    respuesta = "TOPE DE ACTIVIDADES ALCANZADO";
                }
                else if (actividad.Inscriptos.Count >= actividad.MaxInscriptos)
                { //Este lo agregamos nosotros porque nos parecio adecuado.
                    respuesta = "TOPE DE CUPOS EN LA ACTIVIDAD ALCANZADO";
                }
            }
            else if (postulante == null)
            {
                respuesta = "SOCIO INEXISTENTE";
            }
            else if (actividad == null)
            {
                respuesta = "ACTIVIDAD INEXISTENTE";
            }

            return respuesta;

        }
    }
}

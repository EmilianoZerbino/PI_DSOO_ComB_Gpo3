﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI__App_Club_Deportivo_.Entidades
{
    public class Profesor : Persona
    {

        public int NMatricula { get; set; }
        public Profesor(int dni, string nombres, string apellidos, Direccion direccion, string nacionalidad, int nMatricula)
             : base(dni, nombres, apellidos, direccion, nacionalidad)
        {
            NMatricula = nMatricula;
        }

    }
}
using System;
using System.Collections.Generic;

namespace Laboratorio06
{
    public class Departamento : División
    {
        List<Sección> Secciones;

        public Departamento(String nombre) : base(nombre)
        {
        }
    }
}

using System;
using System.Collections.Generic;

namespace Laboratorio06
{
    public class Área : División
    {
        List<Departamento> Departamentos;

        public Área(String nombre, Persona encargado) : base(nombre, encargado)
        {
        }
    }
}

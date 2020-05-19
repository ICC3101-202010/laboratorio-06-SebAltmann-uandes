using System;
using System.Collections.Generic;

namespace Laboratorio06
{
    public class Bloque : División
    {
        List<Persona> Personal;

        public Bloque(String nombre, Persona encargado, List<Persona> personal) : base(nombre, encargado)
        {
            this.Personal = personal;
        }
    }
}

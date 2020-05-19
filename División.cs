using System;
namespace Laboratorio06
{
    public class División
    {
        private string Nombre;
        Persona Encargado;

        public División(String nombre)
        {
            this.Nombre = nombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}

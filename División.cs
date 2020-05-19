using System;
namespace Laboratorio06
{
    public class División
    {
        private string Nombre;
        Persona Encargado;

        public División(String nombre, Persona encargado)
        {
            this.Nombre = nombre;
            this.Encargado = encargado;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}

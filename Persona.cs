using System;
namespace Laboratorio06
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string RUT;
        private string Cargo;

        public Persona(String nombre, String apellido, String rut, String cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.RUT = rut;
            this.Cargo = cargo;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetApellido()
        {
            return Apellido;
        }

        public string GetRUT()
        {
            return RUT;
        }

        public string GetCargo()
        {
            return Cargo;
        }
    }
}

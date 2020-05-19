using System;
using System.Runtime.Serialization;

namespace Laboratorio06
{
    [Serializable]
    public class Empresa
    {
        private string Nombre;
        private string RUT;

        public Empresa(String nombre, String rut)
        {
            this.Nombre = nombre;
            this.RUT = rut;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetRUT()
        {
            return RUT;
        }
    }
}

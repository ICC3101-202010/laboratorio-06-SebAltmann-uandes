using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Laboratorio06
{
    [Serializable]
    public class Empresa
    {
        private string Nombre;
        private string RUT;
        List<División> Divisiones;

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

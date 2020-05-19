using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio06
{
    class MainClass
    {
        public static void Save(Empresa empresa, IFormatter formatter)
        {
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }

        public static void Load(IFormatter formatter)
        {
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Empresa empresa = (Empresa)formatter.Deserialize(stream);

            stream.Close();
        }

        public static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();

            while (true)
            {
                String response = "X";
                while(response != "S" && response != "s" && response != "N" && response != "n")
                {
                    Console.Write("Desea cargar los datos de una empresa?  {S/N}");
                    response = Console.ReadLine();
                    if (response != "S" && response != "s" && response != "N" && response != "n")
                    {
                        Console.WriteLine("Esa respuesta no es válida.");
                    }
                }

                if (response.ToUpper() == "S")
                {
                    try
                    {
                        Load(formatter);
                    }
                    catch(FileNotFoundException FNFE)
                    {
                        Console.WriteLine("No se pudo encontrar el archivo 'empresas.bin'.");
                        Console.WriteLine(FNFE.Message);

                        String new_nombre_e;
                        String new_rut_e;

                        Console.Write("Nombre de la empresa nueva: ");
                        new_nombre_e = Console.ReadLine();

                        Console.Write("RUT de la empresa nueva: (XX.XXX.XXX-X)  ");
                        new_rut_e = Console.ReadLine();

                        Empresa new_empresa = new Empresa(new_nombre_e, new_rut_e);

                        Save(new_empresa, formatter);
                    }
                }
                else if (response.ToUpper() == "N")
                {
                    String new_nombre_e;
                    String new_rut_e;

                    Console.Write("Nombre de la empresa nueva: ");
                    new_nombre_e = Console.ReadLine();

                    Console.Write("RUT de la empresa nueva: (XX.XXX.XXX-X)  ");
                    new_rut_e = Console.ReadLine();

                    Empresa new_empresa = new Empresa(new_nombre_e, new_rut_e);

                    Save(new_empresa, formatter);
                }

                return;
            }
        }
    }
}

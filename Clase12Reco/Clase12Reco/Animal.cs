using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12Reco
{
    internal class Animal
    {
        public Animal()
        {
            Console.WriteLine("Ha nacido un animal!!!");
        }
    }
    class Perro: Animal
    {
        public Perro(string n)
        {
            Console.WriteLine("\nHa nacido un Perro!!\nSe llama: " + n + "\n");
        }
    }
    class Gato: Animal
    {
        public Gato()
        {
            Console.WriteLine("\nHa nacido un Gato!!!");
        }
        public Gato(string n)
        {
            Console.WriteLine("\nHa nacido un Gato!!\nSe llama: " + n + "\n");
        }
    }
    class GatoSiames: Gato
    {
        public GatoSiames(string n)
        {
            Console.WriteLine("\nHa nacido un gato Siamés!!\nSe llama: " + n + "\n");
        }
    }
}

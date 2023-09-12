namespace Clase12Reco
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Animal a = new();
            //GatoSiames gs = new GatoSiames("Pinino");
            GatoSiames gs = new("Pinino");
            Perro p= new Perro("Pancho");
            Gato g = new Gato("Michifus");
            Console.ReadKey();
        }
    }
}
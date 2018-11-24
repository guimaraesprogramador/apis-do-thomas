using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface;
using apis.class_e_interface.classe;
namespace apis
{
    class Program
    {
        static void Main(string[] args)
        {
            //construct();
            activador();
        }
        public static void activador()
        {
            Console.WriteLine("Activador");
            Console.WriteLine("Motocicleta:");
            object motocicletaa = Activator.CreateInstance(typeof(Motocicleta));
            Console.WriteLine("Carro:");
            object carro = Activator.CreateInstance(typeof(Carro));
            Console.WriteLine("Caminhão:");
            object caminhão = Activator.CreateInstance(typeof(Caminhão));
            Console.WriteLine("Bicicleta:");
            object bicicleta = Activator.CreateInstance(typeof(Bicicleta));
            Console.WriteLine("Cadeira de rodas:");
            object cadeira_Rodas = Activator.CreateInstance(typeof(Cadeira_rodas));
            Console.ReadKey();
        }
        public static void construct()
        {
            Console.WriteLine("Construct");
            Console.WriteLine("Motocicleta: ");
            Motocicleta motocicleta = new Motocicleta();
            Console.WriteLine("Carro:");
            Carro carro = new Carro();
            Console.WriteLine("Caminhão:");
            Caminhão caminhão = new Caminhão();
            Console.WriteLine("Bicicleta:");
            Bicicleta bicicleta = new Bicicleta();
            Console.WriteLine("Cadeira de rodas:");
            Cadeira_rodas cadeira_Rodas = new Cadeira_rodas();
            Console.ReadKey();
        }
    }
}

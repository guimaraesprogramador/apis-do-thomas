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
            Console.WriteLine("Motocicleta");
            Motocicleta motocicleta = new Motocicleta();
            Console.WriteLine("Carro:");
            Carro carro = new Carro();
            Console.WriteLine("Caminhão:");
            Caminhão caminhão = new Caminhão();
            Console.WriteLine("Bicicleta:");
            Bicicleta bicicleta = new Bicicleta();
            Console.ReadKey();
        }
    }
}

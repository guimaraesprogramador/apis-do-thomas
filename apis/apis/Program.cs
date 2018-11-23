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
            Carro carro = new Carro();
            Caminhão caminhão = new Caminhão();
            Console.ReadKey();
        }
    }
}

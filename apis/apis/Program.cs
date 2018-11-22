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
            Motocicleta motocicleta = new Motocicleta();
            Veiculo V = (Veiculo)motocicleta;
            Console.ReadKey();
        }
    }
}

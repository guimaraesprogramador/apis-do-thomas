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
            activador();
        }
        public static void activador()
        {
            Console.WriteLine("Activador");
            Console.WriteLine("Motocicleta:");
            Motocicleta motocicleta =(Motocicleta) Motocicleta.Veiculo_fabrica(typeof(Motocicleta), "yomana", "novo 2018");
            Console.WriteLine("eixos da motocicleta: " +motocicleta.eixos);
            Console.WriteLine("Marca da motocicleta: "+motocicleta.marca);
            Console.WriteLine("Modelo da motocicleta: " + motocicleta.modelo);
            Console.WriteLine("potencia da motocicleta: " + motocicleta.potencia);
            Console.WriteLine("gerar nova placa motocicleta: " + motocicleta.emplacar());
            Console.WriteLine("placa atual da motocicleta: " + motocicleta.placa);
            Console.WriteLine(" ");
            Console.WriteLine("Carro:");
           Carro carro =(Carro) Carro.Veiculo_fabrica(typeof(Carro), "go", "novo 2017");
            Console.WriteLine("eixos da carro: " + carro.eixos);
            Console.WriteLine("Marca da carro: " + carro.marca);
            Console.WriteLine("Modelo da carro: " + carro.modelo);
            Console.WriteLine("potencia do carro: " + carro.potencia);
            Console.WriteLine("gerar nova placa CARRO: " + carro.emplacar());
            Console.WriteLine("placa atual do caminhão: " + carro.placa);
            Console.WriteLine(" ");
            Console.WriteLine("Caminhão:");
            Caminhão caminhão = (Caminhão)Caminhão.Veiculo_fabrica(typeof(Caminhão), "scanian ab", "novo 2016");
            Console.WriteLine("eixos do caminhão: " + caminhão.eixos);
            Console.WriteLine("Marca do caminhão: " + caminhão.marca);
            Console.WriteLine("Modelo do caminhão: " + caminhão.modelo);
            Console.WriteLine("potencia do caminhão: " + caminhão.potencia);
            Console.WriteLine("gerar nova placa caminhão: " + caminhão.emplacar());
            Console.WriteLine("placa atual : " +caminhão.placa);
            Console.WriteLine(" ");
            Console.WriteLine("Bicicleta: ");
            Bicicleta bicicleta = (Bicicleta)Bicicleta.Veiculo_fabrica(typeof(Bicicleta), "caloi", "elite");
            Console.WriteLine("eixos da bicicleta: " + bicicleta.eixos);
            Console.WriteLine("Marca da bicicleta: " + bicicleta.marca);
            Console.WriteLine("Modelo da bicicleta: " + bicicleta.modelo);
            Console.WriteLine(" ");
            Console.WriteLine(" Cadeira de  rodas: ");
            Cadeira_rodas cadeira_ = (Cadeira_rodas)Cadeira_rodas.Veiculo_fabrica(typeof(Cadeira_rodas), "fighter", "alfa");
            Console.WriteLine("eixos da Cadeira de  rodas: " + cadeira_.eixos);
            Console.WriteLine("Marca da Cadeira de  rodas: " + cadeira_.marca);
            Console.WriteLine("Modelo da Cadeira de  rodas: " + cadeira_.modelo);
            Console.WriteLine("potencia da Cadeira de  rodas: " + cadeira_.potencia);
            Console.ReadKey();
        }
    }
}

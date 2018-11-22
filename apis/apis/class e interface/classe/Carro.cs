using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
    class Carro : Veiculo
    {
        public Carro():base("go","novo 2017", 2)
        {
            //placa de carro e pontencia de carro
            Console.WriteLine("Marca: " + this.marca + "Modelo: " + this.modelo
                + "Numero de eixos:" + this.eixos+"placa: " + placa +
                "potencia:"+potencia+" cavalos");

        }

    }
}

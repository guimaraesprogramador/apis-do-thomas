using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
  class Motocicleta:Veiculo
    {
        public Motocicleta():base("Yamaha", "XTZ 150 CrosserZ ", 2)
        {
            Console.WriteLine("Marca: " + this.marca + "Modelo: " + this.modelo
                + "Numero de eixos:" + this.eixos);
        }
        public void Numero_veiculo_motorizado()
        {
            //placa de motorizado e pontencia de motorizado
            double resultado_eixos = Math.Pow(this.eixos, potencias_motorizado);
            Console.WriteLine("Marca: " + this.marca + "Modelo: " + this.modelo
               + "Numero de eixos:" + this.eixos + "placa: " +Placas_motorizado +
               "potencia:" + resultado_eixos + " cavalos");
        }
        

    }
}

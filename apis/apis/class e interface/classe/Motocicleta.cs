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
            
            Console.WriteLine("Marca: " + this.marca + ",Modelo: " + this.modelo
                + " ,Numero de eixos:" + this.eixos+ ", potencia:"+this.potencias_Motocicleta
                +", placa:"+Placas_Motocicleta);
        }
        public override float potencias_Motocicleta
        {

            get
            {
                return 25000;
            }
        }
        public void Numero_veiculo_motorizado()
        {
           
        }
        

    }
}

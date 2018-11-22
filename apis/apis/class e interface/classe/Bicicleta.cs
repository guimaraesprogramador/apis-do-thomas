using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface;
namespace apis.class_e_interface.classe
{
    class Bicicleta:Veiculo
{
        public Bicicleta():base("BIK","BARRA Cicluar", 2)
        {
            Console.WriteLine("Marca: " + this.marca + "Modelo: " + this.modelo
                +"Numero de eixos:"+this.eixos);
        }
}
}

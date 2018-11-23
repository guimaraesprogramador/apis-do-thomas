using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apis.class_e_interface.classe
{
    class Caminhão:Veiculo
    {
        public override int tipo_eixos => 5;
        public Caminhão():base("Mercedes-Benz","novo 2018",  5)
        {
            Console.WriteLine("Marca: " + this.marca + ", Modelo: " + this.modelo
                + ",Numero de eixos: " + this.eixos + ",placa:  " + this.placa_caminhão +
                ",potencia: " + this.potencias_caminhão);
        }
        public override float potencias_caminhão => 480000;
        public override string placa_caminhão => "hjkaa000";
    }
}

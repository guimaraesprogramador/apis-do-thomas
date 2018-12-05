using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
   internal class Carro : Veiculo,Iplaca,Ipontencia
    {
        public Carro()
        {

        }
        public override int eixos => Detran.eixo(2);
        public string placa { get; private set; }

        public float potencia => Detran.POTENCIA(100);

        public string emplacar()
        {
            placa = Detran.gerarplacanova();
            return placa;
        }
    }
}

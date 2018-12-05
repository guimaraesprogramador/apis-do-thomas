using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
    class Caminhão:Veiculo,Iplaca,Ipontencia,ieixos
    {
        public Caminhão()
        {
            
        }
        public override int eixos => Detran.eixo(5);
        public float potencia => Detran.POTENCIA(1000);

        public string placa { get; private set; }

        public string emplacar()
        {
            placa = Detran.gerarplacanova();
            return placa;
        }
    }
}

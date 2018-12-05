using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
   class Motocicleta:Veiculo,Iplaca,Ipontencia
    {
        public Motocicleta()
        {
            
         
        }

        public string placa { get; private set; }

        public float potencia => Detran.POTENCIA(60);

        public string emplacar()
        {
            placa = Detran.gerarplacanova();
            return placa;
        }
    }
}

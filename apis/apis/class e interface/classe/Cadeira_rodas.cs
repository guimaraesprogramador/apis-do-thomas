using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
    class Cadeira_rodas:Veiculo,Ipontencia
    {
        public Cadeira_rodas() 
        {
            
        }

        public float potencia => Detran.POTENCIA(25);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
    public class Detran: Ipontencia, Iplaca
    {

      
       public virtual string Placas_motorizado
        {
            get
            {
                return placa;
            }
            
                
        }
            
       public virtual float potencias_motorizado
        {
            get
            {
                return potencia ;
            }
            
        }

        public float potencia => 25;

        public  string placa => "xss555";
    }
}

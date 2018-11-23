using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
 internal class Detran: Ipontencia, Iplaca
    {

    
       public virtual string Placas_Motocicleta
        {
            get
            {
                return placa;
            }
            
                
        }
            
       public virtual float potencias_Motocicleta
        {
            get
            {
                return potencia ;
            }
            
        }
        public virtual float potencias_caminhão
        {
            get
            {
                return potencia;
            }
        }
        public virtual string placa_caminhão
        {
            get
            {
                return placa;
            }
        }
        
        public float potencia => 25;

        public  string placa => "xss555";

        public void potencia_Motocicleta()
        {
            Veiculo motocicleta = new Veiculo();
            Console.WriteLine("Marca: " + motocicleta.marca + "Modelo: " + motocicleta.modelo
              + "Numero de eixos:" + motocicleta.eixos + "placa: " + motocicleta.Placas_Motocicleta +
              "potencia:" + motocicleta.potencias_Motocicleta + " cavalos");
        }
        public void eixos_numero_caminhão()
        {
            Caminhão caminhão = new Caminhão();
            Console.WriteLine("Marca: " +caminhão.marca + "Modelo: " + caminhão.modelo
             + "Numero de eixos:" + caminhão.eixos + "placa: " + caminhão.Placas_Motocicleta +
             "potencia:" + caminhão.potencias_caminhão + " cavalos");
        }
    }
}

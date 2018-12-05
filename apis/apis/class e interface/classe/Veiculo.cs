using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.classe;
namespace apis.class_e_interface
{
    class Veiculo: Imodelo,imarca,ieixos
    {
        public  string modelo { get; private set; }
        public string marca { get; private set; }
       
        public static Veiculo Veiculo_fabrica(Type tipo,string Marca,string Modelo)
        {
         Veiculo vv = (Veiculo)Activator.CreateInstance(tipo);
            vv.marca = Marca;
            vv.modelo = Modelo;
            return vv;
        }
        //placa de Motocicleta;


        public virtual int eixos => 2;
        
      
    }
}

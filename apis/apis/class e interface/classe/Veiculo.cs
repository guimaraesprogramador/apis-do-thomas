using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.classe;
namespace apis.class_e_interface
{
   public class Veiculo:Detran, Imodelo,imarca,ieixos
    {
        public string modelo { get; }
        public string marca { get;  }
        public virtual int tipo_eixos
        {
            get
            {
                return eixos;
            }
            
        }
        //placa da veiculo motorizado;
        public override string Placas_motorizado
        {
            get
            {
                return "8xs55";
            }
        }
        public override float potencias_motorizado
        {

            get
            {
                return 25000;
            }
        } 
        public int eixos { get; }
        public Veiculo(string Marca, string Modelo,int Eixos)
        {
            this.eixos = Eixos;
            this.marca = Marca;
            this.modelo = Modelo;
           
        }
    }
}

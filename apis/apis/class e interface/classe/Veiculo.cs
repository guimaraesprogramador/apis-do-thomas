using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.classe;
namespace apis.class_e_interface
{
   internal class Veiculo:Detran, Imodelo,imarca,ieixos
    {
        public string modelo { get; }
        public string marca { get;  }
        public Veiculo()
        {

        }
        public virtual int tipo_eixos
        {
            get
            {
                return eixos;
            }
            
        }
        //placa de Motocicleta;
        public override string Placas_Motocicleta
        {
            get
            {
                return "8xs55";
            }
        }
        //potencia de Motocicleta;
        public override float potencias_Motocicleta
        {

            get
            {
                return 25000;
            }
        }
        public override float potencias_caminhão
        {
            get
            {
                return 360000;
            }
        }

        public int eixos { get; }
        public Veiculo(string Marca, string Modelo, int Eixos)
        {
            
            this.marca = Marca;
            this.modelo = Modelo;
            if(Eixos == 2)
            {
                this.eixos = Eixos;
            }
            else
            {
                Eixos = tipo_eixos;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.classe;
namespace apis.class_e_interface
{
    class Veiculo:Detran, Imodelo,imarca,ieixos
    {
        public string modelo { get; set; }
        public string marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual int tipo_eixos
        {
            get
            {
                return eixos;
            }
            set
            {
                eixos = eixos;
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
        public int eixos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Veiculo(string Marca, string Modelo,int Eixos)
        {
            Marca = this.marca;
            Modelo = this.modelo;
            Eixos = this.eixos;
        }
    }
}

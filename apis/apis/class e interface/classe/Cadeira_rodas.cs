using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apis.class_e_interface.classe
{
    class Cadeira_rodas:Veiculo
    {
        public Cadeira_rodas() : base("Ortobras", "Branco", 2)
        {
            Console.WriteLine("Marca: " + this.marca + ", Modelo: " + this.modelo
               + ", Numero de eixos:" + this.eixos);
        }
    }
}

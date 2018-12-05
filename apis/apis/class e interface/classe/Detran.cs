using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apis.class_e_interface.interfaces;
namespace apis.class_e_interface.classe
{
  class Detran
    {


      

        public static int eixo(int tipo_eixo)
        {
           
            if(tipo_eixo == 2)
            {
                return 2;
            }
            else
            {
                return tipo_eixo;
            }
        }
        public static float POTENCIA(float tipo_potencia)
        {
            if(tipo_potencia > 100)
            {
                return 100;
            }
            else
            {
                return tipo_potencia;
            }
          
        }
        public static string gerarplacanova()
        {
            Random random = new Random();
            const string letras ="abcdefghijklemopqrst" ;
            const string numeros_inteiros ="0123456789";
            string placa_letras = new string(Enumerable.Repeat(letras, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            string placa_numeros = new string(Enumerable.Repeat(numeros_inteiros, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            return placa_letras + placa_numeros;
        }
    }
}

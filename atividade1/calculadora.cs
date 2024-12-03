using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class calculadora
    {
        public int somar(int numero1, int numero2) 
        {
            int resultado = 0;
            resultado = numero1 + numero2;

            return  resultado;

        }
        public int subtrair(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 - numero2;

            return resultado;

        }
        public int mutiplicar(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 * numero2;

            return resultado;

        }
        public int dividir(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 / numero2;

            return resultado;

        }
     
    }
}

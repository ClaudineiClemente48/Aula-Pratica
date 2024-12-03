using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicios exer = new exercicios();
            //exer.Resultado();

            /*
             Menu de escolha....
            Perguntar os numeros
            mensagem bonita de retorno
             */
            
            calculadora calc = new calculadora();

            int somar = calc.somar(7, 8);
            Console.WriteLine($"soma: {somar}");

            int subtrair= calc.subtrair(7, 8);
            Console.WriteLine($"subtrair: {subtrair}");

            int mutiplicar = calc.mutiplicar(7, 8);
            Console.WriteLine($"mutiplicar: {mutiplicar}");

            int dividir = calc.dividir(7, 8);
            Console.WriteLine($"dividir: {dividir}");

            Console.WriteLine("press Enter.... ");
            Console.ReadKey();


            Console.WriteLine("Escolha uma operacao para validar;");

            somar = int.Parse(Console.ReadLine());

            if (somar = somar )
            {
                Console.WriteLine(" ");

            }
            else if (numero < 0)
            {

                Console.WriteLine("O numero é negativo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("é igual a zero");

            }
        }












    }

    }
}



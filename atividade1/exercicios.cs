using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class exercicios

    {
        public void Teste()
        {
            Console.WriteLine("Testandoooo  1, 2, 3 ");
        }
        public void Resultado() 
        {
            while (true)
            {
                Console.WriteLine("1 - Atividade_01");
                Console.WriteLine("2 - Atividade_02");
                Console.WriteLine("3 - Atividade_03");
                Console.WriteLine("4 - Atividade_04");
                Console.WriteLine("5 - Atividade_05");
                Console.WriteLine("6 - Atividade_06");

                Console.WriteLine("x - Sair");

                Console.WriteLine("Escolha uma atividade: ");
                String esc = Console.ReadLine();

                if (esc == "1")
                {
                    atividade_01();
                }
                else if (esc == "2")
                {
                    atividade_02();
                }
                else if (esc == "3")
                {
                    atividade_03();
                }
                else if (esc == "4")
                {
                    atividade_04();
                }
                else if (esc == "5")
                {
                    atividade_05();
                }
                else if (esc == "6")
                {
                    atividade_06();
                }
                if (esc == "x")
                {
                    break;
                }
            }

            void atividade_01()
            {
                //escreva um programa que verifica se o numero e fornecido pelo usuario é positivo, negativo ou zero
                int numero = 0;

                Console.WriteLine("digite um numero para validar;");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine(" O numero positivo");

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

            void atividade_02()
            {
                //Escreva um programa que leia um mês do ano e informe quantos dias ele tem.
                int mes = 0;

                Console.Write("Digite o mês: ");

                mes = int.Parse(Console.ReadLine());

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    Console.WriteLine("O mês tem 31 dias");
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    Console.WriteLine("O mes tem 30 dias");
                }
                else if (mes == 2)
                {
                    Console.WriteLine("O mes tem 28 ou 29 dias");

                }
            }

            void atividade_03()
            {
                //Faça um programa que leia a nota de um aluno e informe se ele está aprovado(nota maior ou igual a 7), em recuperação(nota entre 5 e 7) ou reprovado(nota menor que 5).


                int nota = 0;

                Console.WriteLine("Digite sua nota: ");

                nota = int.Parse(Console.ReadLine());

                if (nota >= 7)
                {
                    Console.WriteLine("Ele esta aprovado. ");
                }
                else if (nota <= 6)
                {
                    Console.WriteLine("Ele esta recuperacao.");
                }
                else if (nota <= 5)
                {
                    Console.WriteLine("Ele esta reprovado");
                }
            }

            void atividade_04()
            {
                //Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição. //5050

                int soma = 0;

                for (int i = 1; i <= 100; i++)
                {
                    soma += i;

                }

                Console.WriteLine("A soma total dos numeros de 1 a 100:" + soma);
            }

            void atividade_05()
            {
                //Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.


                for (int i = 1; i >= 10; i--)
                {
                    Console.WriteLine(i);
                }
            }

            void atividade_06()
            {
                //Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e informe se ele está aprovado (média maior ou igual a 7) ou reprovado.

                Console.WriteLine("Digite o nome do aluno: ");
                String nome = Console.ReadLine();

                Console.WriteLine("digite sua primeira nota: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua segunda nota: ");
                float nota2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua terceira nota: ");
                float nota3 = float.Parse(Console.ReadLine());

                float media = (nota1 + nota2 + nota3) / 3;

                Console.WriteLine($"A média do aluno {nome} é {media:F2}.");

                if (media >= 7)
                {
                    Console.WriteLine(" Aluno aprovado! ");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado! ");
                }
            }
            }
        }
}

using System;

namespace Terrenosretangulares.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Algoritmo para identificar Triângulos");

                Console.WriteLine("Digite 1 para Verificar o Tipo de Triângulo");

                Console.WriteLine("Digite s para sair");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                if (opcao != "1" && opcao != "s")
                {
                    Console.WriteLine("Opção do Menu Invalida ");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.Write("Digite o 1 Lado do Triângulo: ");
                string strlado1 = Console.ReadLine();
                double lado1 = System.Convert.ToDouble(strlado1);

                Console.Write("Digite o 2 Lado do Triângulo: ");
                string strlado2 = Console.ReadLine();
                double lado2 = System.Convert.ToDouble(strlado2);

                Console.Write("Digite o 3 Lado do Triângulo: ");
                string strlado3 = Console.ReadLine();
                double lado3 = System.Convert.ToDouble(strlado3);


                if (lado1 < lado2 + lado3 && lado2 < lado3 + lado1 && lado3 < lado2 + lado1)
                {
                    if (opcao == "1")
                    {

                        if (lado1 == lado2 && lado2 == lado3)
                        {
                            Console.WriteLine("O seu Triângulo é Equilátero ");
                        }
                        else if (lado1 == lado2 && lado2 != lado3 || lado1 != lado2 && lado2 == lado3 || lado3 != lado1 && lado2 == lado3)
                        {
                            Console.WriteLine("O seu Triângulo é Isósceles ");
                        }
                        else if (lado1 != lado2 && lado2 != lado3)
                        {
                            Console.WriteLine("O seu Triângulo é Escaleno ");
                        }

                    }
                else
                        Console.WriteLine("Opção Invalida ");
                }

                Console.ReadLine();


            } while (true);
        }
    }
}

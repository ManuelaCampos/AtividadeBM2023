using System;

namespace AtividadeBM
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;

            while (opcao != 0)
            {

                Console.WriteLine("*********************************************Atividade da Bárbara e da Manu********************************************* \nEscolha uma opção do menu:");
                Console.WriteLine("1) Somar números");
                Console.WriteLine("2) Converter de metros para milímetros");
                Console.WriteLine("8) Tabuada de cada número");
                Console.WriteLine("0) Sair");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("OPA! opção não existe em nosso menu.Pressione Enter para continuar...");
                    Console.ReadLine();
                    continue;
                }

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        Console.Write("Insira o primeiro número: ");
                        double num1 = ReadDouble();
                        Console.Write("Insira o segundo número: ");
                        double num2 = ReadDouble();
                        double resultadoSoma = Somador.Somar(num1, num2);
                        Console.WriteLine($"Resultado da soma: {resultadoSoma}");
                        break;
                    case 2:
                        Console.Write("Insira a medida em metros: ");
                        double metros = ReadDouble();
                        double milimetros = Conversor.Converter(metros);
                        Console.WriteLine($"{metros} metros equivalem a {milimetros} milímetros.");
                        break;
                    case 8:
                        Console.Write("Insira um número para a tabuada: ");
                        int numeroTabuada = ReadInt();
                        string tabuada = Tabuada.GerarTabuada(numeroTabuada);
                        Console.WriteLine(tabuada);
                        break;
                    default:
                        Console.WriteLine("OPA! opção não existe em nosso menu.Pressione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("Pressione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }

        static double ReadDouble()
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Valor inválido. Insira um número válido:");
            }
            return value;
        }

        static int ReadInt()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Valor inválido. Insira um número válido:");
            }
            return value;
        }
    }
}
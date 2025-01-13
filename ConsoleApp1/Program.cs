using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            Faturamento faturamento = new Faturamento();
            RepresentatividadePorEstadoDistribuidora representatividade = new RepresentatividadePorEstadoDistribuidora();
            InversorDeStrings inversor = new InversorDeStrings();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha o exercício a ser executado:");
                Console.WriteLine("1 - Verificar se o número pertence à sequência de Fibonacci");
                Console.WriteLine("2 - Calcular faturamento da distribuidora");
                Console.WriteLine("3 - Calcular percentuais de representação por estado");
                Console.WriteLine("4 - Inverter uma string");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite o número da opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        fibonacci.PertenceAFibonacci();
                        break;

                    case 2:
                        faturamento.CalculaFaturamentos();
                        break;

                    case 3:
                        representatividade.CalculaRepresentatividadePorEstado();
                        break;

                    case 4:
                        inversor.Inverter();
                        break;

                    case 5:
                        Console.WriteLine("Saindo...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}


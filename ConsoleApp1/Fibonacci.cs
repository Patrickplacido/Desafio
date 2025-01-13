using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Fibonacci
    {
        public List<int> GerarSequencia(int limite)
        {
            List<int> sequencia = new List<int> { 0, 1 };

            while (true)
            {
                int proximo = sequencia[sequencia.Count - 1] + sequencia[sequencia.Count - 2];
                if (proximo > limite)
                    break;
                sequencia.Add(proximo);
            }
            
            return sequencia;
        }

        public void PertenceAFibonacci()
        {
            Console.WriteLine("Digite o número que deseja saber se pertence à Fibonacci: ");
            var entrada = Console.ReadLine();

            int.TryParse(entrada, out int numero);

            List<int> sequencia = GerarSequencia(numero);
            var pertence = sequencia.Contains(numero);

            if (pertence)
                Console.WriteLine("O número pertence à sequência de Fibonacci.");
            else
                Console.WriteLine("O número não pertence à sequência de Fibonacci.");
        }
    }
}

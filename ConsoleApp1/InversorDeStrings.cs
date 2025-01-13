using System;

namespace ConsoleApp1
{
    public class InversorDeStrings
    {
        public void Inverter()
        {
            Console.WriteLine("Digite uma string para inverter:");
            string entrada = Console.ReadLine();

            Pilha pilha = new Pilha(entrada.Length);

            foreach (char c in entrada)
            {
                pilha.Empilhar(c);
            }

            string resultadoInvertido = "";
            while (!pilha.EstaVazia())
            {
                resultadoInvertido += pilha.Desempilhar();
            }

            Console.WriteLine("String invertida: " + resultadoInvertido);
        }
    }
}

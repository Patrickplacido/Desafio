using System;
namespace ConsoleApp1
{
    public class Pilha
    {
        private char[] elementos;
        private int topo;
        private int capacidade;

        public Pilha(int capacidade)
        {
            this.capacidade = capacidade;
            this.elementos = new char[capacidade];
            this.topo = -1;
        }

        public void Empilhar(char elemento)
        {
            if (topo < capacidade - 1)
            {
                topo++;
                elementos[topo] = elemento;
            }
            else
            {
                Console.WriteLine("Pilha cheia!");
            }
        }

        public char Desempilhar()
        {
            if (topo >= 0)
            {
                char elemento = elementos[topo];
                topo--;
                return elemento;
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
                return '\0';  // Retorna valor nulo para indicar erro
            }
        }

        public bool EstaVazia()
        {
            return topo == -1;
        }
    }
}

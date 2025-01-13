using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class RepresentatividadePorEstadoDistribuidora
    {
        public List<EstadoFaturamento> Faturamentos { get; set; }

        public void CarregarDados(string caminhoArquivo)
        {
            string json = File.ReadAllText(caminhoArquivo);
            var dados = JsonConvert.DeserializeObject<RepresentatividadePorEstadoDistribuidora>(json);
            Faturamentos = dados.Faturamentos;
        }

        private double CalcularFaturamentoTotal()
        {
            double faturamentoTotal = 0;
            foreach (var estado in Faturamentos)
            {
                faturamentoTotal += estado.Faturamento;
            }
            return faturamentoTotal;
        }

        private void CalcularPercentuais(double faturamentoTotal)
        {
            Console.WriteLine("Percentual de representação de cada estado no faturamento total:");

            foreach (var estado in Faturamentos)
            {
                double percentual = (estado.Faturamento / faturamentoTotal) * 100;
                Console.WriteLine($"{estado.Estado}: {percentual:F2}%");
            }
        }

        public void CalculaRepresentatividadePorEstado()
        {
            CarregarDados("./faturamento2.json");

            double faturamentoTotal = CalcularFaturamentoTotal();

            CalcularPercentuais(faturamentoTotal);
        }
    }

    public class EstadoFaturamento
    {
        public string Estado { get; set; }
        public double Faturamento { get; set; }
    }
}

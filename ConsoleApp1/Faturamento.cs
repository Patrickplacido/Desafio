using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    public class Faturamento
    {
        public void CalculaFaturamentos()
        {
            List<FaturamentoDia> faturamentos = LerFaturamento("faturamento.json");

            double menorFaturamento = ObterMenorFaturamento(faturamentos);
            Console.WriteLine($"O menor valor de faturamento ocorrido em um dia foi R$ {menorFaturamento}.");

            double maiorFaturamento = ObterMaiorFaturamento(faturamentos);
            Console.WriteLine($"O maior valor de faturamento ocorrido em um dia foi R$ {maiorFaturamento}.");

            int diasAcimaDaMedia = ObterDiasAcimaDaMedia(faturamentos);
            Console.WriteLine($"O número de dias com faturamento superior à média mensal foi {diasAcimaDaMedia}.");
        }
        public List<FaturamentoDia> LerFaturamento(string caminhoArquivo)
        {
            string json = File.ReadAllText(caminhoArquivo);
            FaturamentoData faturamentoData = JsonConvert.DeserializeObject<FaturamentoData>(json);
            return faturamentoData.Faturamentos;
        }

        public double ObterMenorFaturamento(List<FaturamentoDia> faturamentos)
        {
            return faturamentos.Where(f => f.Valor > 0).Min(f => f.Valor);
        }

        public double ObterMaiorFaturamento(List<FaturamentoDia> faturamentos)
        {
            return faturamentos.Max(f => f.Valor);
        }

        public int ObterDiasAcimaDaMedia(List<FaturamentoDia> faturamentos)
        {
            var faturamentosValidos = faturamentos.Where(f => f.Valor > 0).ToList();
            double mediaMensal = faturamentosValidos.Average(f => f.Valor);
            return faturamentosValidos.Count(f => f.Valor > mediaMensal);
        }
    }

    public class FaturamentoDia
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }

    public class FaturamentoData
    {
        public List<FaturamentoDia> Faturamentos { get; set; }
    }
}

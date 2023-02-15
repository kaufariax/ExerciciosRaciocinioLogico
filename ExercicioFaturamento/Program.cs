using System.Text.Json;

namespace ExercicioFaturamento
{
    class Program
    {
        static void Main(string[] args)
        {

            List<FaturamentoDiario> listaFaturamentoDiario = ConverterJsonEmFaturamentoMensal("dados.json");
            List<FaturamentoDiario> listaFaturamentoDiasUteis = listaFaturamentoDiario.Where(faturamento => faturamento.valor != 0.0).ToList();

            var menorFaturamento = listaFaturamentoDiasUteis.MinBy(faturamento => faturamento.valor);
            var maiorFaturamento = listaFaturamentoDiasUteis.MaxBy(faturamento => faturamento.valor);
            var mediaFaturamentoMensal = CalcularMediaDiasUteis(listaFaturamentoDiasUteis);
            var diasFaturamentoAcimaDaMedia = listaFaturamentoDiasUteis.Where(faturamento => faturamento.valor > mediaFaturamentoMensal).Count();

            Console.WriteLine($"O menor faturamento do mês foi no dia {menorFaturamento.dia} no valor de: {Math.Round(menorFaturamento.valor, 2)}");
            Console.WriteLine($"O maior faturamento do mês foi no dia {maiorFaturamento.dia} no valor de: {Math.Round(maiorFaturamento.valor, 2)}");
            Console.WriteLine($"A média de faturamento do mês foi no valor de: {Math.Round(mediaFaturamentoMensal, 2)}");
            Console.WriteLine($"O número de dias em que o valor de faturamento diário foi superior à média mensal foi de: {diasFaturamentoAcimaDaMedia}");


            // Métodos Auxiliares

            static double CalcularMediaDiasUteis(List<FaturamentoDiario> listaFaturamentoDiasUteis)
            {
                int diasUteis = listaFaturamentoDiasUteis.Select(faturamento => faturamento.dia).Count();
                double totalFaturado = listaFaturamentoDiasUteis.Sum(faturamento => faturamento.valor);

                double mediaDiasUteis = totalFaturado / diasUteis;
                return mediaDiasUteis;
            }

            static List<FaturamentoDiario> ConverterJsonEmFaturamentoMensal(string nomeDoArquivo)
            {
                StreamReader arquivoFaturamento = new StreamReader(nomeDoArquivo);
                string faturamentoEmFormatoString = arquivoFaturamento.ReadToEnd();

                List<FaturamentoDiario> listaFaturamentoDiario = System.Text.Json.JsonSerializer.Deserialize<List<FaturamentoDiario>>(faturamentoEmFormatoString)!;
                return listaFaturamentoDiario;
            }
        }
    }
}
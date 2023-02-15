namespace ExercicioFaturamentoPorEstado
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dicionarioEstadosFaturamentos = new Dictionary<string, double>();
            dicionarioEstadosFaturamentos.Add("SP", 67836.43);
            dicionarioEstadosFaturamentos.Add("RJ", 36678.66);
            dicionarioEstadosFaturamentos.Add("MG", 29229.88);
            dicionarioEstadosFaturamentos.Add("ES", 27165.48);
            dicionarioEstadosFaturamentos.Add("Outros", 19849.53);

            double totalFaturamentoDistribuidora = dicionarioEstadosFaturamentos.Sum(faturamento => faturamento.Value);
            
            CalcularPercentualRepresentadoPorEstado(dicionarioEstadosFaturamentos, totalFaturamentoDistribuidora);

            // Método de Cálculo
            static void CalcularPercentualRepresentadoPorEstado(Dictionary<string, double> dicionarioEstadosFaturamentos, double totalFaturamentoDistribuidora)
            {
                foreach(var estadoFaturamento in dicionarioEstadosFaturamentos.Where(faturamento => faturamento.Key != "Outros"))
                {
                    var percentualDoEstado = (estadoFaturamento.Value) / totalFaturamentoDistribuidora * 100;
                    Console.WriteLine($"O percentual de representação do Estado {estadoFaturamento.Key} em relação ao faturamento total é de: {Math.Round(percentualDoEstado, 2)}%");
                }
            }
        }
    }
}
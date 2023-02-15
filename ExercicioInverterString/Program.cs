namespace ExercicioInverterString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Deseja ver como fica um texto invertido? Digite-o aqui: ");
            string? stringParaInverter = Console.ReadLine();
            char[] caracteresDaString = stringParaInverter.ToCharArray();

            for (int i = 0; i < stringParaInverter.Length / 2; i++)
            {
                char caracterAtual = caracteresDaString[i];
                char caracterOposto = caracteresDaString[stringParaInverter.Length - i - 1];

                caracteresDaString[i] = caracterOposto;
                caracteresDaString[stringParaInverter.Length - i - 1] = caracterAtual;
            }

            Console.WriteLine(caracteresDaString);
        }
    }
}
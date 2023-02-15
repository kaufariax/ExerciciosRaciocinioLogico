namespace ExercicioFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numeroAnterior = 0, numeroAtual = 1, numeroFibonacci;
                int[] sequenciaFibonacci = new int[100];

                Console.WriteLine("Digite um número inteiro para validar se ele pertence à sequência Fibonacci iniciada em 0 (considerando os 100 primeiros termos): ");
                int numeroValidar = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 100; i++)
                {
                    numeroFibonacci = numeroAnterior + numeroAtual;
                    numeroAnterior = numeroAtual;
                    numeroAtual = numeroFibonacci;

                    sequenciaFibonacci[i] = numeroFibonacci;
                }

                if (sequenciaFibonacci.Contains(numeroValidar))
                {
                    Console.WriteLine("O número informado pertence à sequência Fibonacci !");
                }
                else
                {
                    Console.WriteLine("O número informado não pertence à sequência Fibonacci !");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não é um número inteiro");
            }

        }
    }
}
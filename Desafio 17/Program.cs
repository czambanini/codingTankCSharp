internal class Program
{
    private static void Main(string[] args)
    {
        int tamanho;
        int penultimo = 0;
        int ultimo = 1;
        string resultado = "Sequencia Fibonacci: ";

        try
        {
            //entrada com tryparse + while para não aceitar não inteiros
            Console.WriteLine("GERADOR DE SEQUÊNCIA FIBONACCI");
            Console.Write("Quantidade de números desejados: ");
            while (!int.TryParse(Console.ReadLine(), out tamanho) || tamanho < 0)
            {
                Console.Write("Número inválido, digite de novo: ");
            }

            if (tamanho == 0)
            {
                resultado = $"{resultado}0";
            }
            else if (tamanho == 1)
            {
                resultado = $"{resultado}0, 1";
            }
            else
            {
                resultado = $"{resultado}0, 1";
                for (int i = 3; i <= tamanho; i++)
                {
                    int numero = ultimo + penultimo;
                    penultimo = ultimo;
                    ultimo = numero;
                    resultado = $"{resultado}, {numero}";

                }
            }

            Console.WriteLine(resultado);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }

        
    }
}
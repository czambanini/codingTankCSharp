internal class Program
{
    private static void Main(string[] args)
    {
        int soma = 0;
        for (int i = 1; i < 101; i++) { 
        soma = soma + i;
        }

        Console.WriteLine(soma);

    }
}
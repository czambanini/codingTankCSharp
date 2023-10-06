internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a nota da 1ª prova: ");
        float prova1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota da 2ª prova: ");
        float prova2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota da 3ª prova: ");
        float prova3 = int.Parse(Console.ReadLine());

        float media = (prova1 + prova2 + prova3) / 3;

        if (media >= 7)
        {
            Console.WriteLine("O aluno passou.");
        } else
        {
            float exame = 10 - media;
            Console.WriteLine($"O aluno ficou de exame e precisa tirar {exame}");
        };


    }
}
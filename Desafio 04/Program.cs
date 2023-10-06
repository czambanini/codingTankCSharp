class Program
{
    private static void Main(string[] args)
    {
        //desafio 04
        Console.WriteLine("Valor em reais: ");
        double reais = int.Parse(Console.ReadLine());
        double dolares = reais * 0.19;
        double iene = reais * 28.69;

        Console.WriteLine($"R$ {reais} equivale a:");
        Console.WriteLine($"{dolares} dolares");
        Console.WriteLine($"{iene} ienes");
    }
}
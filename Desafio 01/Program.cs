class Program
{
    private static void Main(string[] args)
    {
        //desafio 01
        Console.Write("Digite um número inteiro: ");
        int numA = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número inteiro: ");
        int numB = int.Parse(Console.ReadLine());

        int soma = numA + numB;
        int sub = numA - numB;
        double div = numA / numB;
        int mult = numA * numB;

        Console.Write($"Os resultados são soma {soma}, subtração {sub}, divisão {div} e multiplicação {mult}");
    }
}
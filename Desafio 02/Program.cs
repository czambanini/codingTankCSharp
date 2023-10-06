class Program
{
    private static void Main(string[] args)
    {
        //desafio 02
        Console.WriteLine("Digite o ano atual: ");
        int anoAtual = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o ano do seu nascimento: ");
        int anoNasc = int.Parse(Console.ReadLine());

        int idade = anoAtual - anoNasc;
        Console.WriteLine($"Você tem ou fara {idade} anos esse ano");
    }
}
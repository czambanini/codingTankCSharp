class Program
{
    private static void Main(string[] args)
    {
        //desafio 03
        Console.WriteLine("Valor da conta: ");
        double valorConta = double.Parse(Console.ReadLine());
        Console.WriteLine("Porcentagem de gorjeta: ");
        int gorjeta = int.Parse(Console.ReadLine());

        double valorGorjeta = valorConta * gorjeta / 100;
        double totalConta = valorConta + valorGorjeta;

        Console.WriteLine($"Sua conta deu {totalConta} e o valor pago de gorjeta é {valorGorjeta}");

        //como evitar erro se a pessoa passar o caracter %?
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write($"Digite seu salário: ");
        float salarioAntigo = float.Parse(Console.ReadLine());
        int percentual;

        if (salarioAntigo <= 280){
            percentual = 20;
        } else if (salarioAntigo <= 700){
            percentual = 15;
        } else if (salarioAntigo <= 1500) {
            percentual = 10;
        } else {
            percentual = 5;
        };

        float aumento = salarioAntigo * percentual / 100;
        float salarioNovo = salarioAntigo + aumento;

        Console.WriteLine($"Salário antes do reajuste: R${salarioAntigo}");
        Console.WriteLine($"Percentual de aumento: {percentual}%");
        Console.WriteLine($"Valor do aumento: R${aumento}");
        Console.WriteLine($"Novo salário: R${salarioNovo}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //criação das variaveis pescaDoDia, limitePesca e valorMulta
        Console.WriteLine("Peso da pesca do dia:");
        float pescaDoDia = float.Parse(Console.ReadLine());
        float limitePesca = 50.00F;
        float valorMulta = 4.00F;

        if (pescaDoDia > limitePesca)
        {
            float diferenca = pescaDoDia - limitePesca;
            float multa = diferenca * valorMulta;
            Console.WriteLine($"Houve exeço de {diferenca}kg");
            Console.WriteLine($"Valor a ser pago: R${multa}");
        } else
        {
            Console.WriteLine($"Peso exetido: 0kg.");
            Console.WriteLine("Não haverá multa.");

        }

        //tratar número negativo e letras como entrada do pescaDoDia

    }
}
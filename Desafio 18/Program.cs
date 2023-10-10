internal class Program
{

    private static void Main(string[] args)
    {
        Random numAleatorio = new Random();
        int certo = numAleatorio.Next(1, 101);

        int chute;
        int contador = 1;

        Console.WriteLine("Faça um chute de 1 a 100: ");
        while (!int.TryParse(Console.ReadLine(), out chute) || chute < 1 || chute > 100)
        {
            Console.Write("Número inválido, digite de novo: ");
        }


        while (chute != certo)
        {
            if (chute < certo)
            {
                Console.WriteLine($"O número é maior que {chute}\n");
            }
            else
            {
                Console.WriteLine($"O número é menor que {chute}\n");
            }

            contador++;
            Console.WriteLine("Tente de novo: ");
            while (!int.TryParse(Console.ReadLine(), out chute) || chute < 1 || chute > 100)
            {
                Console.Write("Número inválido, digite de novo: ");
            }
        }

        if (chute == certo)
        {
            Console.WriteLine($"Parabens você acertou em {contador} tentativas!");
        }



    }
}
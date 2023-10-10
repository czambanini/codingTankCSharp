internal class Program
{
    private static void Main(string[] args)
    {
        int stop = 1;
        int contador = 0;
        int soma = 0;

        do {
            Console.Write("Digite um número (ou 0 para parar a aplicação): ");
            int.TryParse(Console.ReadLine(), out int numero);

            if (numero == 0){
                stop = 0;
            } else {
                soma = soma + numero;
                contador++;
            }
        } while (stop != 0);

        Console.WriteLine($"Você digitou {contador} números e a soma é {soma}");

        //faltou dizer quantos são pares o.o
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int numero1, numero2, maior;
        int soma = 0;

        //receber os números, repetindo caso o valor não seja inteiro
        Console.Write("Digite 1° número inteiro: ");
        while (!int.TryParse(Console.ReadLine(), out numero1)) {
            Console.Write("Número inválido, digite de novo: ");
        }
        Console.Write("Digite 2° número inteiro: ");
        while (!int.TryParse(Console.ReadLine(), out numero2)) {
            Console.Write("Número inválido, digite de novo: ");
        }

        //inverter os números caso o primeiro seja maior que o segundo
        if (numero2 < numero1) {
            maior = numero1;
            numero1 = numero2;
            numero2 = maior;
        }

        //percorre o interevalo somando a variável soma os números pares
        for (int i = numero1; i <= numero2; i++) {
            if (i % 2 == 0) {
                soma = soma +  i;
            }
        }

        Console.WriteLine($"Soma dos números pares = {soma}");

    }
}
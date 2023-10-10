internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int soma = 0;

        //preenchimento do array
        for (int i = 0; i < numeros.Length; i++) {
            Console.Write($"Digite o {i+1}° número:");
            int.TryParse(Console.ReadLine(), out numeros[i] );
        }

        //soma dos números e checagem do menor
        int menor = numeros[0];
        for (int i = 0;i < numeros.Length;i++) {
            soma = soma + numeros[i];

            if (numeros[i] < menor) {
                menor = numeros[i];
            }
        }

        float media = (float)soma / numeros.Length;

        Console.Write($"\nA média dos números é {media} \nA soma dos números é {soma} \nO menor número é {menor}");

    }
}
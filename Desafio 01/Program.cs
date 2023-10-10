class Program
{
    private static void Main(string[] args)
    {
        int numA, numB, operacao;

        //tratamento com TryParse + While para repetir a pergunta enquanto o usuário não digitar um número inteiro
        Console.Write("Digite o 1º número inteiro: ");
        while (!int.TryParse(Console.ReadLine(), out numA)){
            Console.Write("Número inválido, digite de novo: ");
        }
        Console.Write("Digite o 2º número inteiro: ");
        while (!int.TryParse(Console.ReadLine(), out numB)) {
            Console.Write("Número inválido, digite de novo: ");
        }
        

        Console.WriteLine("\n1. adição \n2. subtração \n3. divisão \n4. multiplicação");
        do{
            Console.Write("Digite o número da operação desejada: ");
        } while (!int.TryParse(Console.ReadLine(), out operacao));

        //switch case para escolha da operação
        switch (operacao)
        {
            case 1:
                int soma = numA + numB;
                Console.Write($"{numA} + {numB} = {soma}");
                break;
            case 2:
                int sub = numA - numB;
                Console.Write($"{numA} - {numB} = {sub}");
                break;
            case 3:
                float div = (float)numA / numB;
                Console.Write($"{numA} / {numB} = {div:F2}");
                break;
            case 4:
                int mult = numA * numB;
                Console.Write($"{numA} * {numB} = {mult}");
                break;
            default:
                Console.Write("Número não cadastrado. Fim da aplicação.");
                break;
        }

    }
}
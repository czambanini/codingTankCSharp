internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. Analise e Desenvolvimento de Sistemas");
        Console.WriteLine("2. Segurança da Informação");
        Console.WriteLine("3. Redes e Infraestrutura");
        Console.WriteLine("4. Banco de Dados");
        Console.WriteLine(" ");

        Console.WriteLine("Digite o número do curso:");
        int curso = int.Parse(Console.ReadLine());
        switch (curso)
        {
            case 1:
                Console.WriteLine("Analise e Desenvolvimento de Sistemas");
                Console.WriteLine("Tuma A: De segunda a sexta das 7h às 13h");
                Console.WriteLine("Tuma B: De segunda a sábado das 19h às 22h");
                Console.WriteLine("Tuma C: Turma EAD");
                break;
            case 2:
                Console.WriteLine("Segurança da Informação");
                Console.WriteLine("Tuma A: De segunda a sexta das 7h às 13h");
                Console.WriteLine("Tuma B: De segunda a sábado das 19h às 22h");
                Console.WriteLine("Tuma C: Turma EAD");
                break;
            case 3:
                Console.WriteLine("Redes e Infraestrutura");
                Console.WriteLine("Tuma A: De segunda a sexta das 7h às 13h");
                Console.WriteLine("Tuma B: De segunda a sábado das 19h às 22h");
                Console.WriteLine("Tuma C: Turma EAD");
                break;
            case 4:
                Console.WriteLine("Banco de Dados");
                Console.WriteLine("Tuma A: De segunda a sexta das 7h às 13h");
                Console.WriteLine("Tuma B: De segunda a sábado das 19h às 22h");
                Console.WriteLine("Tuma C: Turma EAD");
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }
}
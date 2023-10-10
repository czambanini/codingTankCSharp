internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            //impedir idades negativas, menores que 5 e maiores que 100
            while (idade < 5 || idade > 100)
            {
                Console.Write("Idade invalida, digite novamente: ");
                idade = int.Parse(Console.ReadLine());
            };

            //verificação da turma
            if (idade < 8){
                Console.WriteLine("Infantil A");
            }
            else if (idade < 12){
                Console.WriteLine("Infantil B");
            }
            else if (idade < 14){
                Console.WriteLine("Juvenil A");
            }
            else if (idade < 18){
                Console.WriteLine("Juvenil B");
            }
            else{
                Console.WriteLine("Adulto");
            };

        }
        catch (FormatException)
        {
            Console.WriteLine("A idade só aceita valores númericos.");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

     }
}
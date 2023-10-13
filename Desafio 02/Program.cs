using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    private static void Main(string[] args)
    {
        //data de hoje
        DateTime dataHoje = DateTime.Today;

        //pede a data de nascimento do usuário
        DateTime dataNasc;
        Console.WriteLine("Digite a data do seu nascimento: ");
        while (!DateTime.TryParse(Console.ReadLine(), new CultureInfo("pt-BR"), DateTimeStyles.None, out dataNasc))
        {
            Console.Write("Formato inválido, digite de novo: ");
        }

        int idade = dataHoje.Year - dataNasc.Year;
        if (dataHoje.Month == dataNasc.Month && dataHoje.Day < dataNasc.Day)
        {
            idade = idade - 1;
            Console.WriteLine($"Você tem {idade} anos.");
        } 
        else if (dataHoje.Month < dataNasc.Month)
        {
            idade = idade - 1;
            Console.WriteLine($"Você tem {idade} anos.");
        } else
        {
            Console.WriteLine($"Você tem {idade} anos.");
        }

    }
}
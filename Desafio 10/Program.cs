﻿using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escreva uma palavra: "); 
        string palavra = Console.ReadLine();
        int tamanho = palavra.Length;
        string reverso = "";

        for (int i = 0; i < tamanho; i++) {
            string letra = palavra.Substring(tamanho - i - 1, 1);
            reverso = reverso + letra;
        }

        //Console.WriteLine(reverso);

        if (palavra == reverso)
        {
            Console.WriteLine("Essa palavra é um palindromo");
        } else
        {
            Console.WriteLine("Não é um palindromo");
        };

    }
}
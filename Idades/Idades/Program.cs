﻿using System.Globalization;

internal class Program
{
    public static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        double media;

        Console.WriteLine("Dados da primeira pessoa:");
        Console.Write("Nome: ");
        string? nome1 = Console.ReadLine();
        Console.Write("Idade: ");
        int idade1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segunda pessoa:");
        Console.Write("Nome: ");
        string? nome2 = Console.ReadLine();
        Console.Write("Idade: ");
        int idade2 = int.Parse(Console.ReadLine());

        media = (idade1 + idade2) / 2.0;

        Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CI) + " anos");
    }
}
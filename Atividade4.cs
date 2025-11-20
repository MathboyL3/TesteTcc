using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número N: ");
        int n = int.Parse(Console.ReadLine());

        long soma = n * (n + 1) / 2;

        Console.WriteLine($"Soma de 1 até {n} = {soma}");
    }
}

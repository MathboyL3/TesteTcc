using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Retorna o maior valor de uma lista de inteiros.
    /// </summary>
    /// <param name="lista">Lista contendo os números inteiros.</param>
    /// <returns>O maior número encontrado.</returns>
    /// <exception cref="ArgumentException">Lançado quando a lista está vazia.</exception>
    static int EncontrarMaior(List<int> lista)
    {
        if (lista.Count == 0)
            throw new ArgumentException("A lista não pode estar vazia.");

        int maior = lista[0];

        // Percorre a lista comparando valores
        foreach (int num in lista)
        {
            if (num > maior)
                maior = num;
        }

        return maior;
    }

    static void Main()
    {
        var numeros = new List<int> { 3, 7, 1, 9, 4 };
        Console.WriteLine($"Maior número: {EncontrarMaior(numeros)}");
    }
}

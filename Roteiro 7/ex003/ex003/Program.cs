using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        Console.WriteLine("Digite vários números inteiros. (Digite 0 para parar):");

        while (true)
        {
            Console.Write("Número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero == 0)
                {
                    break;
                }

                numerosUnicos.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro válido.");
            }
        }

        Console.WriteLine("\n--- Números Únicos Digitados ---");
        foreach (int num in numerosUnicos)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
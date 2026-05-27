using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra para inverter: ");
        string palavra = Console.ReadLine();

        Stack<char> pilhaLetras = new Stack<char>();

        foreach (char letra in palavra)
        {
            pilhaLetras.Push(letra);
        }

        Console.Write("Palavra invertida: ");

        while (pilhaLetras.Count > 0)
        {
            Console.Write(pilhaLetras.Pop());
        }

        Console.WriteLine();
    }
}
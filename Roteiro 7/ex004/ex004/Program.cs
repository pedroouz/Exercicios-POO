using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaAtendimento = new Queue<string>();
        string opcao = "";

        while (opcao != "4")
        {
            Console.WriteLine("\n--- FILA DE ATENDIMENTO ---");
            Console.WriteLine("1. Adicionar cliente à fila");
            Console.WriteLine("2. Atender próximo cliente");
            Console.WriteLine("3. Ver quantidade de clientes na fila");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do cliente: ");
                    string cliente = Console.ReadLine();
                    filaAtendimento.Enqueue(cliente);
                    Console.WriteLine($"'{cliente}' entrou na fila.");
                    break;

                case "2":
                    if (filaAtendimento.Count > 0)
                    {
                        string clienteAtendido = filaAtendimento.Dequeue();
                        Console.WriteLine($"Chamando o cliente: **{clienteAtendido}** para atendimento.");
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia. Nenhum cliente para atender.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Clientes restantes na fila: {filaAtendimento.Count}");
                    break;

                case "4":
                    Console.WriteLine("Encerrando o sistema de fila...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> catalogo = new Dictionary<int, string>();
        string opcao = "";

        while (opcao != "4")
        {
            Console.WriteLine("\nCATÁLOGO DE PRODUTOS");
            Console.WriteLine("1 Adicionar produto");
            Console.WriteLine("2 Buscar produto por código");
            Console.WriteLine("3 Listar todos os produtos");
            Console.WriteLine("4 Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o código do produto (inteiro): ");
                    if (int.TryParse(Console.ReadLine(), out int codigo))
                    {
                        if (catalogo.ContainsKey(codigo))
                        {
                            Console.WriteLine("Erro: Este código de produto já existe!");
                        }
                        else
                        {
                            Console.Write("Digite o nome do produto: ");
                            string nome = Console.ReadLine();
                            catalogo.Add(codigo, nome);
                            Console.WriteLine("Produto cadastrado com sucesso!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Código inválido. Digite um número inteiro.");
                    }
                    break;

                case "2":
                    Console.Write("Digite o código para busca: ");
                    if (int.TryParse(Console.ReadLine(), out int codBusca))
                    {
                        if (catalogo.TryGetValue(codBusca, out string produtoEncontrado))
                        {
                            Console.WriteLine($"Produto encontrado: {produtoEncontrado}");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("\n--- Produtos Cadastrados ---");
                    if (catalogo.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        foreach (KeyValuePair<int, string> produto in catalogo)
                        {
                            Console.WriteLine($"Código: {produto.Key} | Nome: {produto.Value}");
                        }
                    }
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
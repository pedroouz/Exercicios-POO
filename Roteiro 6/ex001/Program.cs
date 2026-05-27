try
{
    Console.WriteLine("Insira o nome do produto:");
    string nome = Console.ReadLine();
    if(string.IsNullOrEmpty(nome))
    {
        throw new Exception("O nome do produto nao pode ser vazio");
    }

    Console.WriteLine("Insira o preço do produto: ");
    double preco = double.Parse(Console.ReadLine());
    if(preco <= 0)
    {
        throw new Exception("O preço deve ser maior que 0");
    }

    Console.WriteLine($"O produto {nome} tem o valor R${preco}");
}
catch(FormatException)
{
    Console.WriteLine("Erro de formato!");
}
catch(Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine("Finalizado!");
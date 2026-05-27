static void VerificarIdade(int idade)
{
    if (idade < 18)
    {
        throw new IdadeInvalidaException("Erro: A idade minima é 18 anos");
    }
    Console.WriteLine("Acesso permitido.");
}

static void Main()
{
    try
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        VerificarIdade(idade);
    }
    catch (IdadeInvalidaException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o CPF (formato livre): ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }


        string cpf = input.Trim()
                          .Replace(".", "")
                          .Replace("-", "")
                          .Replace(" ", "");

        Console.WriteLine($"CPF limpo: {cpf}");

        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF inválido: deve conter 11 dígitos.");
            return;
        }

        if (cpf.StartsWith("0"))
        {
            Console.WriteLine("CPF inválido: não pode começar com 0.");
            return;
        }

        foreach (char c in cpf)
        {
            if (!char.IsDigit(c))
            {
                Console.WriteLine("CPF inválido: deve conter apenas números.");
                return;
            }
        }

        string cpfFormatado =
            cpf.Substring(0, 3) + "." +
            cpf.Substring(3, 3) + "." +
            cpf.Substring(6, 3) + "-" +
            cpf.Substring(9, 2);

        Console.WriteLine($"CPF formatado: {cpfFormatado}");
    }
}
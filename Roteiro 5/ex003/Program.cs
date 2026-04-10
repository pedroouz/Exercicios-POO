class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma frase (com espaços no início/fim e palavras separadas por vírgula): ");
        string? frase = Console.ReadLine();

        if (string.IsNullOrEmpty(frase))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        string fraseTrim = frase.Trim();
        Console.WriteLine($"\nFrase sem espaços extras: {fraseTrim}");


        string[] partes = fraseTrim.Split(',');
        Console.WriteLine("\nPartes da frase:");
        foreach (string parte in partes)
        {
            Console.WriteLine(parte.Trim());
        }

        Console.Write("\nDigite a palavra que deseja substituir: ");
        string? palavraAntiga = Console.ReadLine();

        Console.Write("Digite a nova palavra: ");
        string? palavraNova = Console.ReadLine();

        if (!string.IsNullOrEmpty(palavraAntiga) && palavraNova != null)
        {
            string fraseSubstituida = fraseTrim.Replace(palavraAntiga, palavraNova);
            Console.WriteLine($"Frase após substituição: {fraseSubstituida}");
        }

        Console.Write("\nDigite uma palavra para verificar início: ");
        string? inicio = Console.ReadLine();

        if (!string.IsNullOrEmpty(inicio))
        {
            Console.WriteLine($"Começa com \"{inicio}\"? {fraseTrim.StartsWith(inicio)}");
        }

        Console.Write("\nDigite uma palavra para verificar fim: ");
        string? fim = Console.ReadLine();

        if (!string.IsNullOrEmpty(fim))
        {
            Console.WriteLine($"Termina com \"{fim}\"? {fraseTrim.EndsWith(fim)}");
        }
    }
}
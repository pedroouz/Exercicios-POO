class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nome do evento: ");
        string? nome = Console.ReadLine();

        Console.Write("Data do evento (dd/MM/yyyy): ");
        string? dataInput = Console.ReadLine();

        Console.Write("Valor do ingresso: ");
        string? valorInput = Console.ReadLine();

        Console.Write("Categoria (VIP/Comum): ");
        string? categoriaInput = Console.ReadLine();

        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(dataInput) ||
            string.IsNullOrEmpty(valorInput) || string.IsNullOrEmpty(categoriaInput))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        if (!DateTime.TryParse(dataInput, out DateTime dataEvento))
        {
            Console.WriteLine("Data inválida.");
            return;
        }

        if (!decimal.TryParse(valorInput, out decimal valor))
        {
            Console.WriteLine("Valor inválido.");
            return;
        }

        string categoria = categoriaInput.ToUpper();

        if (!categoria.Contains("VIP") && !categoria.Contains("COMUM"))
        {
            Console.WriteLine("Categoria inválida.");
            return;
        }

        int diasRestantes = (int)Math.Ceiling((dataEvento - DateTime.Now).TotalDays);

        if (diasRestantes < 0)
        {
            Console.WriteLine("O evento já ocorreu.");
            return;
        }

        decimal desconto = 0;

        if (categoria.Contains("VIP"))
        {
            desconto = 0.10m;
        }
        else if (categoria.Contains("COMUM"))
        {
            desconto = 0.05m; 
        }

        decimal valorFinal = valor - (valor * desconto);
        valorFinal = Math.Round(valorFinal, 2);

        Console.WriteLine(string.Format("{0,-20} {1}", "Evento:", nome));
        Console.WriteLine(string.Format("{0,-20} {1:dd/MM/yyyy}", "Data:", dataEvento));
        Console.WriteLine(string.Format("{0,-20} {1}", "Categoria:", categoria));
        Console.WriteLine(string.Format("{0,-20} {1}", "Dias restantes:", diasRestantes));
        Console.WriteLine(string.Format("{0,-20} {1:C}", "Valor original:", valor));
        Console.WriteLine(string.Format("{0,-20} {1:P}", "Desconto:", desconto));
        Console.WriteLine(string.Format("{0,-20} {1:C}", "Valor final:", valorFinal));
    }
}
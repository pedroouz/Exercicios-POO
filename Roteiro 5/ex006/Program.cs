class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();

        Console.Write("Digite a data e hora (dd/MM/yyyy HH:mm): ");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(entrada))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        if (!DateTime.TryParse(entrada, out DateTime compromisso))
        {
            Console.WriteLine("Formato de data inválido.");
            return;
        }

        DateTime agora = DateTime.Now;

        int dias = (int)Math.Ceiling((compromisso - agora).TotalDays);

        if (dias < 0)
        {
            Console.WriteLine("A data informada já passou.");
            return;
        }

        string diaSemana = compromisso.DayOfWeek.ToString();

        switch (diaSemana)
        {
            case "Monday": diaSemana = "segunda-feira"; break;
            case "Tuesday": diaSemana = "terça-feira"; break;
            case "Wednesday": diaSemana = "quarta-feira"; break;
            case "Thursday": diaSemana = "quinta-feira"; break;
            case "Friday": diaSemana = "sexta-feira"; break;
            case "Saturday": diaSemana = "sábado"; break;
            case "Sunday": diaSemana = "domingo"; break;
        }

        string mensagem = string.Format(
            "Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3:dd/MM/yyyy} às {3:HH:mm}",
            nome,
            dias,
            diaSemana,
            compromisso
        );

        Console.WriteLine("\n" + mensagem);
    }
}
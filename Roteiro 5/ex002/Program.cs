class Program
{
    static void Main(string[] args)
    {
        Console.Write("Capital inicial: ");
        double capital = double.Parse(Console.ReadLine()!);

        Console.Write("Taxa de juros mensal (%): ");
        double taxa = double.Parse(Console.ReadLine()!) / 100;

        Console.Write("Número de meses: ");
        int meses = int.Parse(Console.ReadLine()!);

        Console.Write("Meta de lucro: ");
        double meta = double.Parse(Console.ReadLine()!);

        double montante = capital * Math.Pow(1 + taxa, meses);
        double lucro = montante - capital;
        double lucroArredondado = Math.Round(lucro, 2);

        Console.WriteLine($"\nMontante final: {montante:F2}");
        Console.WriteLine($"Lucro: {lucroArredondado:F2}");


        if (lucroArredondado >= meta)
        {
            Console.WriteLine("Meta atingida!");
        }
        else
        {
            Console.WriteLine("Meta não atingida.");
        }
    }
}
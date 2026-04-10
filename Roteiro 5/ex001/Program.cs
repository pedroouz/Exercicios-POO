
class Program
{
    static void Main(string[] args)
    {
        double[] numeros = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número decimal: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        foreach (double num in numeros)
        {
            Console.WriteLine($"Número: {num}");
            Console.WriteLine(Math.Round(num));
            Console.WriteLine(Math.Floor(num));
            Console.WriteLine(Math.Ceiling(num));
            Console.WriteLine(Math.Truncate(num));
        }
    }
}
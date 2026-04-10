class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public decimal Total()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var produtos = new List<Produto>
        {
            new Produto("Teclado", 150.50m, 2),
            new Produto("Mouse", 80.90m, 1),
            new Produto("Monitor", 1200.00m, 1)
        };

        decimal subtotal = 0;

        Console.WriteLine($"{"Produto",-15} {"Preço",10} {"Qtd",5} {"Total",12}");
        Console.WriteLine(new string('-', 45));


        foreach (var p in produtos)
        {
            decimal totalItem = p.Total();
            subtotal += totalItem;

            Console.WriteLine($"{p.Nome,-15} {p.Preco,10:C} {p.Quantidade,5} {totalItem,12:C}");
        }

        Console.WriteLine(new string('-', 45));

        decimal desconto = subtotal * 0.10m;
        decimal totalFinal = subtotal - desconto;

        Console.WriteLine($"{"Subtotal:",-20} {subtotal,15:N2}");
        Console.WriteLine($"{"Desconto (10%):",-20} {desconto,15:P}");
        Console.WriteLine($"{"Total final:",-20} {totalFinal,15:C}");
    }
}
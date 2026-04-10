public class Produto
{
    public string Nome;
    public double Preço;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preço}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }

    public void CalcularValorTotal()
    {
        double result = Preço*Quantidade;
        Console.WriteLine($"Valor Total = R${result} reais");
    }

}

public class Program
{
    public static void Main()
    {
        Produto produto1 = new Produto();
        produto1.Nome = "Amaciante OMO 1L";
        produto1.Preço = 17.89;
        produto1.Quantidade = 2;
        produto1.ExibirDados();
        produto1.CalcularValorTotal();

        Produto produto2 = new Produto();
        produto2.Nome = "Ovos Brancos";
        produto2. Preço = 9.34;
        produto2.Quantidade = 20;
        produto2.ExibirDados();
        produto2.CalcularValorTotal();


        Produto produto3 = new Produto();
        produto3.Nome = "Manteiga Rádio 500g";
        produto3.Preço = 23.89;
        produto3.Quantidade = 3;
        produto3.ExibirDados();
        produto3.CalcularValorTotal();
    }
}
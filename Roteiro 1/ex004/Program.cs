public class ContaBancaria
{
    public string? Titular;
    public int NumeroConta;
    public double Saldo = 0;
    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor} reais realizado com sucesso!");
    }

    public void Sacar(double valor)
    {
        if (Saldo > valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor} reais realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque..");
        }
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {Saldo} reais");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.Titular = "Roberto Alves Gomes";
        conta1.NumeroConta = 10292;
        conta1.Depositar(13000);
        conta1.Sacar(7500);
        conta1.ExibirSaldo();
        Console.WriteLine("\n");

        ContaBancaria conta2 = new ContaBancaria();
        conta2.Titular = "Amanda Silva Frender";
        conta2.NumeroConta = 1037593;
        conta2.Depositar(300);
        conta2.Sacar(400);
        conta2.ExibirSaldo();
        Console.WriteLine("\n");

    }

}
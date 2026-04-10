class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico...");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento realizado com Cartão de Crédito.");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento realizado via Boleto Bancário.");
    }
}


class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento realizado via Pix.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Pagamento> pagamentos = new List<Pagamento>();

        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());

        foreach (Pagamento pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
        }
    }
}
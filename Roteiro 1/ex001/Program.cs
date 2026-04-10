public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e sou {Cargo}.");

    }

    public void MostrarSalario()
    {
        if (Cargo == "Gerente")
        {
            Console.WriteLine("Meu salário é 10000 reais");
        }
        else if (Cargo == "Desenvolvedor")
        {
            Console.WriteLine("Meu salário é 5000 reais");
        }
        else if (Cargo == "Estagiário"){
            Console.WriteLine("Meu salário é 100 reais");
        }
        else
        {
            Console.WriteLine("Não vou te falar meu salário...");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Idade = 30;
        p1.Nome = "João";
        p1.Cargo = "Engenheiro Civil";
        p1.Apresentar();
        p1.MostrarSalario();

        Pessoa p2 = new Pessoa();
        p2.Idade = 42;
        p2.Nome = "Eduardo";
        p2.Cargo = "Gerente";
        p2.Apresentar();
        p2.MostrarSalario();

        Pessoa p3 = new Pessoa();
        p3.Idade = 28;
        p3.Nome = "Jonas";
        p3.Cargo = "Desenvolvedor";
        p3.Apresentar();
        p3.MostrarSalario();

        Pessoa p4 = new Pessoa();
        p4.Idade = 19;
        p4.Nome = "Gabriel";
        p4.Cargo = "Estagiário";
        p4.Apresentar();
        p4.MostrarSalario();
    }
}
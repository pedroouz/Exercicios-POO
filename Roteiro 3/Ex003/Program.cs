/*3 - Crie uma interface chamada IVeiculo com um método chamado Mover(). 
Em seguida, crie duas classes que implementem essa interface:
1. Carro: A classe Carro deve implementar o método Mover() e exibir a mensagem "O carro está se movendo".
2. Bicicleta: A classe Bicicleta também deve implementar o método Mover() e exibir a mensagem "A bicicleta está se movendo".
No método Main, crie uma instância de cada classe e chame o método Mover() de ambas.*/

public interface IVeiculo
{
    void Mover();
}

class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("Carro está movendo.");
    }
}

class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("Bicicleta está movendo.");
    }
}

class Program
{
    static void Main()
    {
        IVeiculo carro = new Carro();
        IVeiculo bike = new Bicicleta();

        carro.Mover();
        bike.Mover();
    }
}
/*
Exercício 2: Classe Carro com Controle de Velocidade
Crie uma classe Carro com os seguintes atributos privados:
● modelo (string)
● velocidadeAtual (int)
Use propriedades (get e set) para:
✔ A velocidadeAtual nunca pode ser menor que 0.
✔ Criar métodos Acelerar(int valor) e Frear(int valor) para modificar a
velocidade.
*/

class Carro
{
    private string _modelo;
    private int _velocidadeAtual = 0;

    public Carro(string modelo)
    {
        _modelo = modelo;
    }

    public int VelocidadeAtual
    {
        get{return _velocidadeAtual;}
        private set
        {
            if(value >= 0) _velocidadeAtual = value;
        }
    }

    public int Acelerar(int valor)
    {
        VelocidadeAtual += valor;
        return VelocidadeAtual;
    }
    
    public int Frear(int valor)
    {
        if (valor <= VelocidadeAtual) VelocidadeAtual -= valor;
        else VelocidadeAtual = 0;
        return VelocidadeAtual;
    }
}


class Program
{
    public static void Main()
    {
        Carro c1 = new Carro("Ferrari");
        c1.Acelerar(80);
        Console.WriteLine($"Velocidade atual: {c1.VelocidadeAtual}");
        c1.Frear(20);
        Console.WriteLine($"Velocidade atual: {c1.VelocidadeAtual}");
        c1.Frear(70);
        Console.WriteLine($"Velocidade atual: {c1.VelocidadeAtual}");
    }
}

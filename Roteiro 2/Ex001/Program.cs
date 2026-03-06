/*Exercício 1: Criando uma Classe Produto
Crie uma classe Produto que tenha os seguintes atributos privados:
● nome (string)
● preco (decimal)
Use propriedades (get e set) para:
✔ Permitir a leitura do nome.
✔ Garantir que o preço nunca seja negativo.
Requisitos:
1. Criar um construtor que recebe o nome e o preço do produto.
2. Criar um método ExibirDetalhes() que imprime nome e preço.*/

class Produto
{
    private string _nome;
    private decimal _preco;

    public Produto(string nome, decimal preco)
    {
        _nome = nome;
        if (preco >= 0)
        {
            _preco = preco;
        }
        else
        {
            _preco = 0;
        }
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Nome do produto: {_nome}\nPreco: {_preco}");
    }

    public string Nome
    {
        get
        {
            return _nome;
        }
    }

    public decimal Preco
    {
        get
        {
            return _preco;
        }
        set
        {
            if (value >= 0)
            {
                _preco = value;
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        Produto p1 = new Produto("Fone de ouvido", -200);
        p1.MostrarDetalhes();
    }
}
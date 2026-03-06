/*
Exercício 3: Criando um Elevador
Crie uma classe Elevador com os seguintes atributos privados:
    ● andarAtual (int)
    ● totalAndares (int)
Use propriedades (get e set) para: 
✔ O andarAtual não pode ser menor que 0 nem maior que totalAndares. 
✔ Criar métodos Subir() e Descer() para mudar o andar atual.
*/

class Elevador
{
    private int _andarAtual = 0;
    private int _totalAndares;

    public Elevador(int totalAndares)
    {
        _totalAndares = totalAndares;
    }
    public int AndarAtual
    {
        get{return _andarAtual;}
        set{ if (value <= _totalAndares && value >= 0) _andarAtual = value; }
    }

    public int Subir()
    {
        return AndarAtual += 1;
    }

    public int Descer()
    {
        return AndarAtual -= 1;
    }
}

class Program
{
    public static void Main()
    {
        Elevador elevador = new Elevador(10);
        elevador.Subir();
        elevador.Subir();
        Console.WriteLine(elevador.AndarAtual);
        elevador.Descer();
        Console.WriteLine(elevador.AndarAtual);
        elevador.Descer();
        elevador.Descer();
        Console.WriteLine(elevador.AndarAtual);
    }
}
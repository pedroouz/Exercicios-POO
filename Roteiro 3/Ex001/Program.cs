class Animal
{
    public string nome;
    public string som;
    public void EmitirSom(string som)
    {
        Console.WriteLine(som);
    }
}

class Cachorro : Animal
{
    
}

class Gato : Animal
{
    
}

class Program
{
    static void Main()
    {
        Cachorro cachorro = new Cachorro();
        cachorro.nome = "Cachorro";
        Console.WriteLine(cachorro.nome);
        cachorro.EmitirSom("Au Au");

        Gato gato = new Gato();
        gato.nome = "Gato";
        Console.WriteLine(gato.nome);
        gato.EmitirSom("Miau");
    }
}

public class Fantasminhas
{
    public string Habilidade;
    public string Nick;
    public string Cor;
    public string Direção;

    public void GerarFantasma()
    {
        Console.WriteLine($"Habilidade: {Habilidade}");
        Console.WriteLine($"Nick: {Nick}");
        Console.WriteLine($"Cor: {Cor}");
    }

    public void Mover(string Direção)
    {
        Console.WriteLine($"{Nick} se moveu para {Direção}");
        Console.WriteLine("\n");
    }
}

public class Program
{
    public static void Main()
    {
        Fantasminhas f1 = new Fantasminhas();
        f1.Habilidade = "Ficar invisivel";
        f1.Nick = "YellowGhost123";
        f1.Cor = "Amarelo";
        f1.GerarFantasma();
        f1.Mover("Cima");

        Fantasminhas f2 = new Fantasminhas();
        f2.Habilidade = "Intangibilidade";
        f2.Nick = "Fantasma_Azul123";
        f2.Cor = "Azul";
        f2.GerarFantasma();
        f2.Mover("Baixo");

        Fantasminhas f3 = new Fantasminhas();
        f3.Habilidade = "Veloz";
        f3.Nick = "Greench";
        f3.Cor = "Verde";
        f3.GerarFantasma();
        f3.Mover("Direita");

        Fantasminhas f4 = new Fantasminhas();
        f4.Habilidade = "Imortabilidade";
        f4.Nick = "Pinky";
        f4.Cor = "Rosa";
        f4.GerarFantasma();
        f4.Mover("Esquerda");
    } 
}
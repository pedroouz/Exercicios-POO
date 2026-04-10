/*4 - Você deve criar um sistema de animais com duas interfaces: uma para voar e outra para nadar.
Em seguida, implemente várias classes que representem animais que possuem essas habilidades.*/

public interface IVoar
{
    void Voar();
}
public interface INadar
{
    void Nadar();
}

class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("Peixe nada.");
    }
}

class Passaro : IVoar
{
    public void Voar()
    {
        Console.WriteLine("Pássaro voa");
    }
}

class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("Pato voa");
    }
    public void Nadar()
    {
        Console.WriteLine("Pato nada");
    }
}

class Program
{
    static void Main()
    {
        Pato pato = new Pato();
        pato.Nadar();
        pato.Voar();

        Passaro passaro = new Passaro();
        passaro.Voar();

        Peixe peixe = new Peixe();
        peixe.Nadar();
    }
}
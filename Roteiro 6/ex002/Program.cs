try
{
    Console.WriteLine("Insira a temperatura");
    string temp = Console.ReadLine();
    float temperatura = float.Parse(temp);

    Console.WriteLine($"Temperatura em Celsius: {temperatura}");
}
catch (FormatException)
{
    Console.WriteLine("Erro de formato!");
}
Console.WriteLine("Finalizado!");

Console.Write("Digite um número: ");
string entrada = Console.ReadLine();

try
{
    int numero = int.Parse(entrada);
    Console.WriteLine($"Você digitou o número: {numero}");
}
catch (FormatException)
{
    Console.WriteLine("Valor inválido digite um número inteiro");
}

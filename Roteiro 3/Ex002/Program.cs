//02 - Crie uma classe pedido que possua em sua composição um item.
class Item
{
    public string? nome;
}

class Pedido
{
    public Item item;
    public Pedido(string nome)
    {
        item = new Item();
        item.nome = nome;
    }
    public void MostrarItem()
    {
        Console.WriteLine(item.nome);
    }
}

class Program
{
    static void Main()
    {
        Pedido pedido = new Pedido("Macarrão");
        pedido.MostrarItem();
    }
}
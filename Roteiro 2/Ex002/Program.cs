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

public class Carro
{
    private string _modelo;
    private int _velocidadeAtual;

    public Carro(string modelo)
    {
        _modelo = modelo;
    }

    public int VelocidadeAtual
    {
        get{return _velocidadeAtual;}
        private set
        {
            if(value >= 0)
            {
                _velocidadeAtual = value;
            }
            else
            {
                _velocidadeAtual = 0;
            }
        }
    }


}
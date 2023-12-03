using System;

// Definição da classe Heroi
class Heroi
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    // Construtor da classe Heroi
    public Heroi(string nome, int idade, string tipo)
    {
        Nome = nome;
        Idade = idade;
        Tipo = tipo;
    }

    // Método para o herói atacar
    public void Atacar()
    {
        string ataque = "";

        // Determinando o tipo de ataque com base no tipo do herói
        switch (Tipo)
        {
            case "mago":
                ataque = "magia";
                break;
            case "guerreiro":
                ataque = "espada";
                break;
            case "monge":
                ataque = "artes marciais";
                break;
            case "ninja":
                ataque = "shuriken";
                break;
            default:
                ataque = "atacou";
                break;
        }

        // Exibindo a mensagem do ataque
        Console.WriteLine($"O {Tipo} atacou usando {ataque}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe Heroi
        Heroi meuHeroi = new Heroi("Super Cachorro", 25, "ninja");

        // Chamando o método Atacar do herói criado
        meuHeroi.Atacar();
    }
}

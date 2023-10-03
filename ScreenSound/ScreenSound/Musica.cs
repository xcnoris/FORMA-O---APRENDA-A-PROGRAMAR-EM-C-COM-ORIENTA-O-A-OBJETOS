class Musica
{
    public  string nome;
    public string artista;
    public int duração;
    public bool disponivel;

    public void ExibirFicaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duração}");
        if (disponivel)
        {
            Console.WriteLine("Disponibilidade: Disponivel no plano");
        } else
        {
            Console.WriteLine("Disponibilidade: Adquira o plano Plus+");
        };
    }

    public void ExibirNomeEArtista()
        {
            Console.WriteLine($"Nome/Artista: {nome} - {artista}");
        }

    }

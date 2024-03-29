﻿class Musica
{
    public Musica(Banda artista, string nome) 
    {
        Artista = artista;
        Nome = nome;
    }


    public string Nome { get; }

    public Banda Artista { get; }

    public int Duracao { get; set; }

    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }


    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponibilidade: Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Disponibilidade: Adquira o plano Plus+");
        };
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }

}
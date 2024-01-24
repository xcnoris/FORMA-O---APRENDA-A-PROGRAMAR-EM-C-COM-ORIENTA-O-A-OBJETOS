class Album
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; set; }

    public int DuracaoTotal 
    {
        get
        {
            return musicas.Sum(m => m.Duracao);
        }
    }


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de Músicas do album {Nome}: \n");
        foreach (var musica in musicas)
        {
         Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse album inteiro, voce precisa de {DuracaoTotal} segundos");
    }
}

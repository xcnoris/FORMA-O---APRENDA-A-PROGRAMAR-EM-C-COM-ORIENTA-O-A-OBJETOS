Musica musica1 = new Musica();
musica1.Nome = "Uma Arlinda Mulher";
musica1.Artista = "Mamonas Assasinas";
musica1.Duracao = 180;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Tempo Perdido";
musica2.Artista = "Legião Urbana";
musica2.Duracao = 300;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();



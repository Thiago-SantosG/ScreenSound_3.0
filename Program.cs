using ScreenSound_3._0.Filtros;
using ScreenSound_3._0.Modelo;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //LinqFilter.FiltrartodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeumArtista(musicas, "YG");

        //var musicasPreferidasDoThiago = new MusicasPreferidas("Thiago");

        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoThiago.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoThiago.ExibirMusicasFavoritas();

        //var musicasPreferidasDoSantos = new MusicasPreferidas("Santos");

        //musicasPreferidasDoSantos.AdicionarMusicasFavoritas(musicas[29]);
        //musicasPreferidasDoSantos.AdicionarMusicasFavoritas(musicas[87]);
        //musicasPreferidasDoSantos.AdicionarMusicasFavoritas(musicas[1002]);
        //musicasPreferidasDoSantos.AdicionarMusicasFavoritas(musicas[989]);
        //musicasPreferidasDoSantos.AdicionarMusicasFavoritas(musicas[1567]);

        //musicasPreferidasDoSantos.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
using ScreenSound_3._0.Modelo;
using System.Linq;

namespace ScreenSound_3._0.Filtros;

internal class LinqFilter
{
    public static void FiltrartodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-> {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneromusical = musicas.Where(musica => 
        musica.Genero!.Contains(genero)).Select(musica => 
        musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical -> {genero}");
        foreach(var artista in artistasPorGeneromusical) 
        {
            Console.WriteLine($"-> {artista}");
        }
    }

    public static void FiltrarMusicasDeumArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"-> {musica.Nome}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine("Musicas em CSharp");
        foreach(var musica in musicasEmCSharp)
        {
            Console.WriteLine($"-> {musica }");
        }
    }
}

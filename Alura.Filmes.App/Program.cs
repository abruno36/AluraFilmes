using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                //var m10 = ClassificacaoIndicativa.MaioresQue18;
                //Console.WriteLine(m10.ParaString());
                //Console.WriteLine("G".ParaValor());

                //var ator1 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };
                //var ator2 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };
                //contexto.Atores.AddRange(ator1, ator2);
                //contexto.SaveChanges();

                //var emmaWatson = contexto.Atores
                //    .Where(a => a.PrimeiroNome == "Emma" && a.UltimoNome == "Watson");
                //Console.WriteLine($"Total de atores encontrados: {emmaWatson.Count()}.");

                var filme = new Filme();
                var idioma = new Idioma { Nome = "English" }; //quando não existe na tabela Language
                filme.Titulo = "Cassino Royale";
                filme.Duracao = 120;
                filme.AnoLancamento = "2000";
                filme.Classificacao = ClassificacaoIndicativa.MaioresQue14;
                filme.IdiomaFalado = contexto.Idiomas.First();
                contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                contexto.Filmes.Add(filme);
                contexto.SaveChanges();

                var filmeInserido = contexto.Filmes.First(f => f.Titulo == "Cassino Royale");
                Console.WriteLine(filmeInserido.Classificacao);

            }
        }
    }
}
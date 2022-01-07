using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //select * from actor
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                //var filmes = contexto.film
                //    .Include(f => f.IdiomaFalado);

                //foreach (var filme in filmes)
                //{
                //    Console.WriteLine(filme);
                //    Console.WriteLine(filme.IdiomaFalado);
                //}

                var idiomas = contexto.Idiomas
                    .Include(i => i.FilmesFalados);

                //foreach (var idioma in contexto.Idiomas)
                //{
                //    Console.WriteLine(idioma);
                //}

                foreach (var idioma in idiomas)
                {
                    Console.WriteLine(idioma);

                    foreach (var filme in idioma.FilmesFalados)
                    {
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("\n");
                }

                //foreach (var idioma in contexto.Idiomas)
                //{
                //    Console.WriteLine(idioma);
                //}

                //var filme = contexto.film
                //    .Include(f => f.Atores)   //inner join
                //    .ThenInclude(fa => fa.Ator)
                //    .First();

                //Console.WriteLine(filme);
                //Console.WriteLine("Elenco");

                //listar os 10 atores modificados recentemente 
                //var atores = contexto.actor
                //    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                //    .Take(10);

                //foreach (var ator in atores)
                //{
                //    Console.WriteLine(ator + " - " + contexto.Entry(ator).Property("last_update").CurrentValue);
                //}

                //listar todos os filmes
                //foreach (var item in contexto.Elenco)
                //{
                //    var entidade = contexto.Entry(item);
                //    var filmId = entidade.Property("film_id").CurrentValue;
                //    var actorId = entidade.Property("actor_id").CurrentValue;
                //    var lastUpd = entidade.Property("last_update").CurrentValue;
                //    Console.WriteLine($"Filme: {filmId}, Ator: {actorId}, LastUpdate: {lastUpd}");
                //}

                //foreach (var ator in filme.Atores)
                //{
                //    Console.WriteLine(ator.Ator);
                //}
            }
        }
    }
}
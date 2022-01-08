using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
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

                // top5_most_starred_actors - view criada no banco legado

                var sql = @"SELECT a.* FROM actor a
	                            inner join top5_most_starred_actors
                                filmes on filmes.actor_id = a.actor_id";

                var atoresMaisAtuantes = contexto.Atores
                    .FromSql(sql)   //não utilizando o sql automatico do EF e sim no sql montado
                    .Include(a => a.Filmografia); 

                foreach (var ator in atoresMaisAtuantes)
                {
                    Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes");
                }
            }
        }
    }
}
using LivrosApi.Data;
using LivrosApi.Models;

namespace LivrosApi.Controllers
{
    public static class LivrosEndpoints
    {
        public static void MapLivroEndpoints(this WebApplication app)
        {   
            var livroRotas = app.MapGroup("livros");
            
            livroRotas.MapGet(string.Empty, (LivroContext db) => db.Livros.ToList());
            livroRotas.MapPost(string.Empty, (LivroInsert req, LivroContext db) => 
            {
                var livro = new Livro(Guid.NewGuid(), req.Nome);
                db.Livros.Add(livro);
                db.SaveChanges();
                return Results.Ok(livro);
            });
        }
    }
}
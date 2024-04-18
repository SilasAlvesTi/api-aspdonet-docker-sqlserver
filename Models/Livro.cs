namespace LivrosApi.Models
{
    public class Livro
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Livro(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
using Domain;

namespace Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly List<Author> _authors = new();

        public IEnumerable<Author> GetAll()
        {
            return _authors;
        }

        public Author Create(Author author)
        {
            _authors.Add(author);
            return author;
        }
    }
}
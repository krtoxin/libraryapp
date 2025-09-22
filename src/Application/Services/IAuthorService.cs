using Domain;

namespace Application.Services
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAll();
        Author Create(Author author);
    }
}
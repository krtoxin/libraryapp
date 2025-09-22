using Domain;

namespace Application.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Create(Book book);
    }
}
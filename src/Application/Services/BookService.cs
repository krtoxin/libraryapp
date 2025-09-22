using Domain;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books = new();

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book Create(Book book)
        {
            _books.Add(book);
            return book;
        }
    }
}
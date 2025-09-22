using Application.Services;
using Domain;
using MediatR;

namespace Application.Books.Commands;

public class CreateBookCommandHandler(
    IBookService bookService) : IRequestHandler<CreateBookCommand, Book>
{
    public Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var book = new Book
        {
            Title = request.Title
        };
        var created = bookService.Create(book);
        return Task.FromResult(created);
    }
}
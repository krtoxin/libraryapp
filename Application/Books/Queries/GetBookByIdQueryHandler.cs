using Application.Services;
using Domain;
using MediatR;

namespace Application.Books.Queries;

public class GetBookByIdQueryHandler(
    IBookService bookService) : IRequestHandler<GetBookByIdQuery, Book>
{
    public Task<Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        var book = bookService.GetAll().FirstOrDefault(b => b.Id == request.Id);
        return Task.FromResult(book);
    }
}
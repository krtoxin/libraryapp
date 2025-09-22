using Application.Services;
using Domain;
using MediatR;
using System.Collections.Generic;

namespace Application.Books.Queries;

public class GetAllBooksQueryHandler(
    IBookService bookService) : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
{
    public Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var books = bookService.GetAll();
        return Task.FromResult(books);
    }
}
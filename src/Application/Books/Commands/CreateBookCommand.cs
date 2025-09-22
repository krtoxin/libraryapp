using Domain;
using MediatR;

namespace Application.Books.Commands;

public record CreateBookCommand : IRequest<Book>
{
    public required string Title { get; init; }
}
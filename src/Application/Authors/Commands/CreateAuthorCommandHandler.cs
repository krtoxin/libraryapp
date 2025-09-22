using Application.Services;
using Domain;
using MediatR;

namespace Application.Authors.Commands;

public class CreateAuthorCommandHandler(
    IAuthorService authorService) : IRequestHandler<CreateAuthorCommand, Author>
{
    public Task<Author> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        var author = new Author
        {
            Name = request.Name,
            BookId = request.BookId
        };
        var created = authorService.Create(author);
        return Task.FromResult(created);
    }
}
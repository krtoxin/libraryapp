using Application.Services;
using Domain;
using MediatR;

namespace Application.Authors.Queries;

public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, Author>
{
    private readonly IAuthorService _authorService;

    public GetAuthorByIdQueryHandler(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    public Task<Author> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
    {
        var author = _authorService.GetAll().FirstOrDefault(a => a.Id == request.Id);
        return Task.FromResult(author);
    }
}
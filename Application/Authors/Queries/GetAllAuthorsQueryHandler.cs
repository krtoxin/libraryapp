using Application.Services;
using Domain;
using MediatR;
using System.Collections.Generic;

namespace Application.Authors.Queries;

public class GetAllAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQuery, IEnumerable<Author>>
{
    private readonly IAuthorService _authorService;

    public GetAllAuthorsQueryHandler(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    public Task<IEnumerable<Author>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
    {
        var authors = _authorService.GetAll();
        return Task.FromResult(authors);
    }
}
using Domain;
using MediatR;

namespace Application.Authors.Commands;

public record CreateAuthorCommand : IRequest<Author>
{
    public required string Name { get; init; }
    public required int BookId { get; init; }
}
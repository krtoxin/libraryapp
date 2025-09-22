using Domain;

namespace Api.Dtos;

public record AuthorDto(int Id, string Name, int BookId)
{
    public static AuthorDto FromDomainModel(Author author)
        => new(author.Id, author.Name, author.BookId);
}

public record CreateAuthorDto(string Name, int BookId);
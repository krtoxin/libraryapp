using Domain;

namespace Api.Dtos;

public record BookDto(int Id, string Title, List<AuthorDto> Authors)
{
    public static BookDto FromDomainModel(Book book)
        => new(
            book.Id,
            book.Title,
            book.Authors.Select(AuthorDto.FromDomainModel).ToList()
        );
}

public record CreateBookDto(string Title, List<string> AuthorNames);
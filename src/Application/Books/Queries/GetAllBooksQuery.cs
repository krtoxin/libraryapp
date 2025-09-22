using Domain;
using MediatR;
using System.Collections.Generic;

namespace Application.Books.Queries;

public class GetAllBooksQuery : IRequest<IEnumerable<Book>>
{
    // No properties needed for "get all"
}
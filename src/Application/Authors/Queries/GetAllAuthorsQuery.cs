using MediatR;
using Domain;

namespace Application.Authors.Queries
{
    public class GetAllAuthorsQuery : IRequest<IEnumerable<Author>>
    {
        
    }
}
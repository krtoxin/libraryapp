using Microsoft.AspNetCore.Mvc;
using MediatR;
using Api.Dtos;
using Application.Authors.Commands;
using Application.Authors.Queries;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorDto>>> GetAll()
        {
            var authors = await _mediator.Send(new GetAllAuthorsQuery());
            return Ok(authors.Select(AuthorDto.FromDomainModel));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorDto>> GetById(int id)
        {
            var author = await _mediator.Send(new GetAuthorByIdQuery(id));
            if (author == null)
                return NotFound();
            return Ok(AuthorDto.FromDomainModel(author));
        }

        [HttpPost]
        public async Task<ActionResult<AuthorDto>> Create([FromBody] CreateAuthorDto dto)
        {
            var command = new CreateAuthorCommand { Name = dto.Name, BookId = dto.BookId };
            var created = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, AuthorDto.FromDomainModel(created));
        }
    }
}
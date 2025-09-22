using Microsoft.AspNetCore.Mvc;
using MediatR;
using Api.Dtos;
using Application.Books.Commands;
using Application.Books.Queries;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAll()
        {
            var books = await _mediator.Send(new GetAllBooksQuery());
            return Ok(books.Select(BookDto.FromDomainModel));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookDto>> GetById(int id)
        {
            var book = await _mediator.Send(new GetBookByIdQuery(id));
            if (book == null)
                return NotFound();
            return Ok(BookDto.FromDomainModel(book));
        }

        [HttpPost]
        public async Task<ActionResult<BookDto>> Create([FromBody] CreateBookDto dto)
        {
            var command = new CreateBookCommand { Title = dto.Title };
            var created = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, BookDto.FromDomainModel(created));
        }
    }
}
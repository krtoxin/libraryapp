using FluentValidation;
using Application.Books.Commands;

namespace Application.Books.Validators;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MinimumLength(2);
    }
}
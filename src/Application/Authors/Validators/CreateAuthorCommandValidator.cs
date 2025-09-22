using FluentValidation;
using Application.Authors.Commands;

namespace Application.Authors.Validators;

public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
{
    public CreateAuthorCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(2);
        RuleFor(x => x.BookId).GreaterThan(0);
    }
}
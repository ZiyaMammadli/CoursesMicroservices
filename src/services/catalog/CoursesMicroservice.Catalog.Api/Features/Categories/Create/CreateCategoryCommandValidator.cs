using FluentValidation;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.Create
{
    public class CreateCategoryCommandValidator:AbstractValidator<CreateCategoryCommandRequest>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(c=>c.name)
                .NotEmpty().WithMessage("{PropertyName} cannot be empty")
                .NotNull().WithMessage("{PropertyName} cannot be null")
                .Length(4,25).WithMessage("{PropertyName} must be between 4 and 25 characters");
        }
    }
}

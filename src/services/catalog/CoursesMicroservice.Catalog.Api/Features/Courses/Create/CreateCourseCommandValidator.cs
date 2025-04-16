using FluentValidation;

namespace CoursesMicroservice.Catalog.Api.Features.Courses.Create
{
    public class CreateCourseCommandValidator:AbstractValidator<CreateCourseCommandRequest>
    {
        public CreateCourseCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("{PropertyName} cannot be empty")
                .NotNull().WithMessage("{PropertyName} cannot be null")
                .Length(4, 25).WithMessage("{PropertyName} must be between 4 and 25 characters");
            RuleFor(c => c.Description)
                .Length(4, 200).WithMessage("{PropertyName} must be between 4 and 200 characters");
            RuleFor(c => c.Price)
                .NotEmpty().WithMessage("{PropertyName} cannot be empty")
                .NotNull().WithMessage("{PropertyName} cannot be null")
                .GreaterThan(0).WithMessage("{PropertyName} must be greateer than 0");
            RuleFor(c => c.ImageUrl)
                .Length(4, 200).WithMessage("{PropertyName} must be between 4 and 200 characters");
            RuleFor(c => c.CategoryId)
                .NotEmpty().WithMessage("{PropertyName} cannot be empty")
                .NotNull().WithMessage("{PropertyName} cannot be null");
        }
    }
}

using CoursesMicroservice.Shared;
using MediatR;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.Create
{
    public record CreateCategoryCommandRequest(string name):IRequest<ServiceResult<CreateCategoryCommandResponse>>;
}

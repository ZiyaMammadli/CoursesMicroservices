using CoursesMicroservice.Shared;
using MediatR;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.GetAll
{
    public class GetAllCategoryQueryRequest:IRequest<ServiceResult<List<GetAllCategoryQueryResponse>>>
    {
    }
}

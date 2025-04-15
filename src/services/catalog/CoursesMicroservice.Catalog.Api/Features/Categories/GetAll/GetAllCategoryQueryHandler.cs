using AutoMapper;
using CoursesMicroservice.Catalog.Api.Repositories;
using CoursesMicroservice.Shared;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.GetAll
{
    public class GetAllCategoryQueryHandler(AppDbContext context, IMapper mapper) : IRequestHandler<GetAllCategoryQueryRequest, ServiceResult<List<GetAllCategoryQueryResponse>>>
    {
        public async Task<ServiceResult<List<GetAllCategoryQueryResponse>>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            List<Category> categories = await context.Categories.ToListAsync();
            var categoryResponses = mapper.Map<List<GetAllCategoryQueryResponse>>(categories);
            return ServiceResult<List<GetAllCategoryQueryResponse>>.SuccessAsOk(categoryResponses);
        }
    }
}

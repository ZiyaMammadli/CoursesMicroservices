using AutoMapper;
using CoursesMicroservice.Catalog.Api.Repositories;
using System.Net;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.GetById
{
    public class GetCategoryByIdQueryHandler(AppDbContext context,IMapper mapper) : IRequestHandler<GetCategoryByIdQueryRequest, ServiceResult<GetCategoryByIdQueryResponse>>
    {
        public async Task<ServiceResult<GetCategoryByIdQueryResponse>> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var category = await context.Categories.FindAsync(request.Id, cancellationToken);
            if (category is null)
            {
                return ServiceResult<GetCategoryByIdQueryResponse>.Error("Category not found",$"Category with id:{request.Id} was not found",HttpStatusCode.NotFound);
            }
            var response=mapper.Map<GetCategoryByIdQueryResponse>(category);

            return ServiceResult<GetCategoryByIdQueryResponse>.SuccessAsOk(response);
        }
    }
}

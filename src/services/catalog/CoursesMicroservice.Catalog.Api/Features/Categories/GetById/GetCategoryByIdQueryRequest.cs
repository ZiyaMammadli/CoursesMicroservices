namespace CoursesMicroservice.Catalog.Api.Features.Categories.GetById
{
    public class GetCategoryByIdQueryRequest:IRequest<ServiceResult<GetCategoryByIdQueryResponse>>
    {
        public Guid Id { get; set; }
    }
}

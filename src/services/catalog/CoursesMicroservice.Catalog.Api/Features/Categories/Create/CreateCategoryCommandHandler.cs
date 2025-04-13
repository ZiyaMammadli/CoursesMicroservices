using CoursesMicroservice.Catalog.Api.Repositories;
using CoursesMicroservice.Shared;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CoursesMicroservice.Catalog.Api.Features.Categories.Create
{
    public class CreateCategoryCommandHandler(AppDbContext context) : IRequestHandler<CreateCategoryCommandRequest, ServiceResult<CreateCategoryCommandResponse>>
    {
        public async Task<ServiceResult<CreateCategoryCommandResponse>> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var existCategory= await context.Categories.AnyAsync(c=>c.Name==request.name,cancellationToken);
            if(existCategory)
            {
                return ServiceResult<CreateCategoryCommandResponse>.Error("Category name already exists", $"Category name : {request.name} already exists", HttpStatusCode.BadRequest);
            }

            Category category= new ()
            {
                Name = request.name,
                Id = NewId.NextSequentialGuid(),
            };

            await context.Categories.AddAsync(category,cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
            return ServiceResult<CreateCategoryCommandResponse>.SuccessAsCreated(new CreateCategoryCommandResponse(category.Id), "<empty>");
        }
    }
}

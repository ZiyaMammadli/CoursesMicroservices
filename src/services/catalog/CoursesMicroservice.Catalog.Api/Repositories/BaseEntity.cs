using MongoDB.Bson.Serialization.Attributes;

namespace CoursesMicroservice.Catalog.Api.Repositories
{
    public class BaseEntity
    {
        [BsonElement("_id")]public Guid Id { get; set; }
    }
}

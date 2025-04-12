using CoursesMicroservice.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoursesMIcroservice.Shared.Extentionsı
{
    public static class EndpointResultExt
    {
        public static IResult ToGenericResult<T>(this ServiceResult<T> result)
        {
            return result.Status switch
            {
                HttpStatusCode.OK=> Results.Ok(result),
                HttpStatusCode.Created=> Results.Created(result.UrlAsCreated,result),
                HttpStatusCode.NotFound=> Results.NotFound(result.Fail!),
                _=> Results.Problem(result.Fail!),
            };
        }    
        public static IResult ToResult(this ServiceResult result)
        {
            return result.Status switch
            {
                HttpStatusCode.NoContent=> Results.NoContent(),
                HttpStatusCode.NotFound=> Results.NotFound(result.Fail!),
                _=> Results.Problem(result.Fail!),
            };
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Filters;

namespace Dapper.API_Clean_Architecture_Repository.Controllers
{
    [Route("api/[controller]")]
    [TypeFilter(typeof(AuthorizationFilterAttribute))]
    [ApiController]
    public class BaseApiController : ControllerBase
    {

    }
}

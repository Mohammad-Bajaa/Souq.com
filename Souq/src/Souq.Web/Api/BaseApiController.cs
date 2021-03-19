using Microsoft.AspNetCore.Mvc;

namespace Souq.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}

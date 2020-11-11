using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // "api/commands" = class (controller) level route
    // [Route("api/[controller]")] 
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        // inherits from Controller Base class (built in)

    }
}
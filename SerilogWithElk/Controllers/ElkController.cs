using Microsoft.AspNetCore.Mvc;

namespace SerilogWithElk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElkController : ControllerBase
    {
        public ElkController()
        {
        }

        [HttpPost]
        public void Post()
        {
        }
    }
}

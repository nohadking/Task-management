using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_management.Areas.Admin.APIsControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderOnlineAPIController : ControllerBase
    {
        MasterDbcontext dbcontext;
        public OrderOnlineAPIController(MasterDbcontext dbcontext = null)
        {
            this.dbcontext = dbcontext;
        }

        public IActionResult AddOrderOnline()
        {
            throw new NotImplementedException();
        }
    }
}

using AlarmAPI.Managers;
using AlarmAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnuresisController : ControllerBase
    {
        private readonly EnuresisManager _manager = new EnuresisManager();

        [HttpGet]
        public ActionResult<IEnumerable<EnuresisAlarm>> GetAll()
        {
            return _manager.GetAll();
        }
    }
}

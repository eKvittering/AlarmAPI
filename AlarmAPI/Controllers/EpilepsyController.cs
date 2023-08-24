using AlarmAPI.Managers;
using AlarmAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpilepsyController : ControllerBase
    {   
        private readonly EpilepsyManager _manager = new EpilepsyManager();

        [HttpGet]
        public ActionResult<IEnumerable<EpilepsyAlarm>> GetAll()
        {
            return _manager.GetAll();
        }
    }
}

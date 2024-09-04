using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController:ControllerBase
    {
        [HttpGet]
        public string SayHi()
        {
            return "Hi, How are You?";
        }
    }
}
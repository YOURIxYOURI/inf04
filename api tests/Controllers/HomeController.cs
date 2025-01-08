using Microsoft.AspNetCore.Mvc;

namespace api_tests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        private List<string> _list = new List<string> { "data 1", "data 2", "data 3", "data 4" };
        public HomeController()
        {

        }

        [HttpGet("/{index}")]
        public string getData(int index)
        {
            return _list[index].ToString();
        }
    }
}

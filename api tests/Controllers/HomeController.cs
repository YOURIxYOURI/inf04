using Microsoft.AspNetCore.Mvc;

namespace api_tests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        AppDbContext _context;

        private List<string> _list = new List<string> { "data 1", "data 2", "data 3", "data 4" };
        public HomeController(AppDbContext context)
        {
            this._context = context;
        }

        //with database get all
        [HttpGet]
        public List<data> GetAllDataDB(int index)
        {
            return _context.datas.ToList();
        }


        //without database
        [HttpGet("/{index}")]
        public string getData(int index)
        {
            return _list[index].ToString();
        }
    }
}

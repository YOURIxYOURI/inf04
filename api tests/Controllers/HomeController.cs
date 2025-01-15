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
        public List<data> GetAllDataDB()
        {
            return _context.Datas.ToList();
        }
        [HttpPost]
        public ActionResult<data> PostData([FromBody] data data)
        {
            if (data != null)
            {
                _context.Datas.Add(data);
            }
            _context.SaveChanges();

            return Ok(data);
        }


        //without database
        [HttpGet("/{index}")]
        public string getData(int index)
        {
            return _list[index].ToString();
        }
    }
}

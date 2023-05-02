using ClockAPI.Model;
using ClockAPI.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClockAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClockReadsController : Controller
    {
        public ClockReadsRepo _repo;
        public ClockReadsController(ClockReadsRepo repo)
        {
            _repo = repo;
        }
        // GET: ClockReadsController
        [HttpGet]
        public List<ClockRead> GetAll()
        {
            return _repo.GetAll();
        }

        // GET: ClockReadsController/Details/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: ClockReadsController/Create
        [HttpPost]
        public void Post([FromBody]ClockRead read)
        {
            _repo.Create(read);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TaskApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var authors= _authorRepository.GetallAuthors();
                return Ok(authors);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
            
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            try
            {
                var authors = _authorRepository.GetallAuthors();
                var author=authors.Where(a => a.Id == id).First();

              if(author is not null) {
                    return Ok(author);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public void Create([FromBody] string value)
        {
        }


        [HttpPut("{id}")]
        public void Update(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

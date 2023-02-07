using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services;
using TaskApi.Services.Models;


namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository authorRepository,IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> Get()
        {
            try
            {
                var authors= _authorRepository.GetallAuthors();
                var authorsmap=_mapper.Map<ICollection<AuthorDto>>(authors);
                return Ok(authorsmap);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return BadRequest(e.Message);
            } 
            
        }

        [HttpGet("{id}")]
        public ActionResult<AuthorDto> Get(int id)
        {

            try
            {
                var authors = _authorRepository.GetallAuthors();
                var author=authors.Where(a => a.Id == id).First();
                var authormap = _mapper.Map<AuthorDto>(authors);

                if (author is not null) {
                    return Ok(authormap);
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

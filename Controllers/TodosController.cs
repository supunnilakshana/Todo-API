using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Services;


namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
       
        private readonly ITodoRepository _todoService;
        public TodosController(  ITodoRepository todoRepository)
        {
            _todoService= todoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var todos = _todoService.GetallTodos();
                return Ok(todos);
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
                var todos = _todoService.GetallTodos();
                var todo = todos.Where(a => a.Id == id).First();

                if (todo is not null)
                {
                    return Ok(todo);
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
        public IActionResult CreateTodo()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTodo()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTodo()
        {
            return Ok();
        }


     

    }
}

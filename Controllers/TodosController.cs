using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Service;
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
        public IActionResult GetTodos(int? id)
        {
            var todos = _todoService.GetallTodos();
            if (id != null)
            {
                return Ok(todos.Where(t => t.Id == id));

            }
            else
            {
                return Ok(todos);
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

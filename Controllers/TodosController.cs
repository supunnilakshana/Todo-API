using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Service;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
       
        private readonly TodoService _todoService;
        public TodosController()
        {
            _todoService= new TodoService();
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

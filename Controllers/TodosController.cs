using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetTodos()
        {


            var todos=getallTodos();    


            return Ok(todos);
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


        private List<Todo> getallTodos()
        {
            var list = new List<Todo>();
            var todo= new Todo {
                                 Id=1,
                                 Title="My todo 1",
                                 Status=TodoStatus.New,
                                 Created=DateTime.Now,
                                 Description="hellowww",
                                 Due=DateTime.Now.AddDays(5),
                               };
            list.Add(todo);
            todo = new Todo
            {
                Id = 2,
                Title = "My todo 2",
                Status = TodoStatus.New,
                Created = DateTime.Now,
                Description = "hellowww",
                Due = DateTime.Now.AddDays(5),
            };
            list.Add(todo);
            todo = new Todo
            {
                Id = 2,
                Title = "My todo 2",
                Status = TodoStatus.New,
                Created = DateTime.Now,
                Description = "hellowww",
                Due = DateTime.Now.AddDays(5),
            };
            list.Add(todo);


            return list;

        }

    }
}

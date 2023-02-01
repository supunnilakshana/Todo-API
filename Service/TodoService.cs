using TaskApi.Models;

namespace TaskApi.Service
{
    public class TodoService
    {
        public List<Todo> GetallTodos()
        {
            var list = new List<Todo>();
            var todo = new Todo
            {
                Id = 1,
                Title = "My todo 1",
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

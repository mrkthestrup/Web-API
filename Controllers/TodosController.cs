using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Entities;
using WebAPIApplication.Repositories;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private ITodoRepository _todoRepository;

        public TodosController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
           IEnumerable<TodoItem> todoItems = _todoRepository.GetAll();
           return new OkObjectResult(todoItems);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //return NoTfound(); - 404 message!
            return new OkObjectResult (_todoRepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]TodoItem todo)
        {
            _todoRepository.Save(todo);
                                //location header               Besked
            return Created("api/todos/" + todo.TodoItemID, "{\"msg\": \"Item Created\"}");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]TodoItem item)
        {
           if (item == null || item.TodoItemID != id) 
           {
               return BadRequest();
           }
            var todo = _todoRepository.Get(id);
            if(todo == null)
            {
                return NotFound();
            }

            todo.IsComplete = item.IsComplete;
            todo.Task = item.Task;

            _todoRepository.Update(todo);
            return new NoContentResult();
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _todoRepository.Delete(id);
            return NoContent();

        }
    }
}

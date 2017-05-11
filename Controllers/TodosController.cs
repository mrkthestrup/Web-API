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
           var todo = _todoRepository.GetAll();
            return new OkObjectResult(todo);
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
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly IRepository<Todo> _repo;

        public TodosController(IRepository<Todo> repo)
        {
            _repo = repo;
        }

        // GET: api/Todoes
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetProducts() => _repo.GetAll().ToList();

        // GET: api/Todoes/5
        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodo(int id)
        {
            var todo = _repo.GetById(id);

            if (todo == null)
            {
                return NotFound();
            }

            return todo;
        }

        [HttpGet]
        [Route("active")]
        public ActionResult<IEnumerable<Todo>> GetActiveTodos() => _repo.GetByCriteria(p => p.IsDone == false).ToList();
        
        [HttpGet]
        [Route("done")]
        public ActionResult<IEnumerable<Todo>> GetDoneTodos() => _repo.GetByCriteria(p => p.IsDone == true).ToList();

        // PUT: api/Todos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutTodo(int id, Todo todo)
        {
            //Task<IActionResult>
            if (id == todo.Id)
            {
                _repo.Update(todo);
                return Ok();
            }
            else return BadRequest();
        }

        // POST: api/Todos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Todo> PostTodo(Todo todo)
        {
            bool created = _repo.Create(todo);
            if(created)
            {
                return CreatedAtAction("GetTodo", new { id = todo.Id }, todo);
            } else
            {
                return BadRequest("Object already present in the database");
            }
            
        }

        // DELETE: api/Todos/5
        [HttpDelete("{id}")]
        public ActionResult<Todo> DeleteTodo(int id)
        {
            var todo = _repo.Remove(id);
            if (todo == null)
            {
                return NotFound();
            }
            return todo;
        }



    }
}

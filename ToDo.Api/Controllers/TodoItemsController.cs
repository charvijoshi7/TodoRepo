using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Coomands;
using TodoApi.Models;
using TodoApi.Query;
using TodoApi.Repository;
using TodoApi.Todo.Data.Repsoitories;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
    
        private readonly IMediator _mediator;

        public TodoItemsController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
       // [ProducesResponseType(404)]
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var query = new GetAllProudctDetail();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _mediator.Send(new GetOrderByIdQuery(id));
            return product != null ? (IActionResult)Ok(product) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> PostTodoItem(TodoItem todoItem)
        {
            CreateProudctCommand command = new CreateProudctCommand(todoItem);
            var result= await _mediator.Send(command);
           return CreatedAtAction("GetById", new { id = result.Id }, result);
           
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        {
            DeleteProductCommand command = new DeleteProductCommand(id);
            var result= await _mediator.Send(command);
            return result;
            
        }

    }
}

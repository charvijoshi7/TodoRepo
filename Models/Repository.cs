using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoApi.Controllers;
namespace TodoApi.Models
{
    public class Repository : TodoItemsController
    {
        
        [AllowAnonymous]
        [HttpPost]
        public ActionResult PostTodoItem1(TodoItem todoItem)
        //public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            // _context.TodoItems.Add(todoItem);
            // await _context.SaveChangesAsync();

            //mediatr
            //_mediator.Publish(todoItem);


            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
            throw new NotImplementedException();
        }
        // GET: api/TodoItems
        [HttpGet]
        //mediatr

        /* public ActionResult GetTodoItems()
         {
             return ;
         }*/
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        /*public ActionResult GetTodoItem(long id)
        {
            
        }*/
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        internal static ActionResult PostTodoItem1()
        {
            throw new NotImplementedException();
        }

        /*internal static ActionResult PostTodoItem()
        {
            throw new NotImplementedException();
        }*/
    }
}

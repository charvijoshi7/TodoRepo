using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Repository
{
    public class ProductRepository:DbContext
    {
        private readonly TodoContext _context;
        public  ProductRepository(TodoContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetItems()
        {
            return await _context.TodoItem.ToListAsync();

        }
        public async void AddItem(TodoItem todoItem)
        {
            _context.TodoItem.Add(todoItem);
            await _context.SaveChangesAsync();
        }
        public async Task<ActionResult<TodoItem>> DeleteItem(long id)
        {
            var todoItem = await _context.TodoItem.FindAsync(id);
            if(todoItem==null)
            {
                return null;
            }
            _context.TodoItem.Remove(todoItem);
            await _context.SaveChangesAsync();
            return todoItem;
        }

        public async Task<ActionResult<TodoItem>> FindtemById(long id)
        {
             return await _context.TodoItem.FindAsync(id);
        }
        private bool TodoItemExists(long id)
        {
            return _context.TodoItem.Any(e => e.Id == id);
        }

    }
}

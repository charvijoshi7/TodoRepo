
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
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
        public async Task<List<TodoItem>> GetAllitem()
        {
            return await _context.TodoItem.ToListAsync();

        }
        public async Task<TodoItem> GetItemById(long id)
        {
            return await _context.TodoItem.FindAsync(id);
        }
        public async Task<TodoItem> AddProudct(TodoItem todoItem)
        {
            _context.TodoItem.Add(todoItem);
            await _context.SaveChangesAsync();
            return todoItem;
        }
        public async Task<TodoItem> DeleteItem(long id)
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


    }
}

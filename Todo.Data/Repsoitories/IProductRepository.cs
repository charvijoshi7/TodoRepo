using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Todo.Data.Repsoitories
{
    interface IProductRepsoitory
    {
        Task<TodoItem> GetItemById(long id);
        Task<List<TodoItem>> GetAllitem();
        Task<TodoItem> AddProudct(TodoItem todoItem);
        Task<TodoItem> DeleteItem(long id);
    }
}

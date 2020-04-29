using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Todo.Data.Repsoitories
{
    public interface IProductRepsoitory
    {
       public  Task<TodoItem> GetItemById(long id);
       public  Task<List<TodoItem>> GetAllitem();
       public  Task<TodoItem> AddProudct(TodoItem todoItem);
       public  Task<TodoItem> DeleteItem(long id);
    }
}

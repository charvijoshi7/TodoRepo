using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
namespace TodoApi.Models

    //handler for post
{
    public class TodoItemHandler : IRequestHandler<TodoItem, bool>
    {
        public async Task<bool> Handle(TodoItem request, CancellationToken cancellationToken)
        {
            // save to database
            Console.WriteLine("Saved todoItem to database");
            return await Task.FromResult(true);
            throw new NotImplementedException();
        }
    }
}

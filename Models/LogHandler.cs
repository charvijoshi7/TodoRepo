using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace TodoApi.Models
{
    public class LogHandler : INotificationHandler<TodoItem>
    {
        /*public Task Handle(TodoItem notification, CancellationToken cancellationToken)
        {
            //Save to log  
            Debug.WriteLine(" ****  User save to log  *****");
            return Task.FromResult(true);

         }    */
        public Task Handle(TodoItem notification, CancellationToken cancellationToken)
        {
            //Save to log
            Console.WriteLine("todoItem saved to log");
            throw new NotImplementedException();
        }
    }
}






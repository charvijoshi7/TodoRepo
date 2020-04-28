using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TodoApi.Coomands
{
    public class CreateProudctCommand :IRequest<TodoItem>
    {
        public TodoItem Item{ get; set; }

        public CreateProudctCommand(TodoItem item)
        {
            Item = item;
        }

       

        
    }
}

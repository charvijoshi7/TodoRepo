using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Coomands
{
    public class DeleteProductCommand : IRequest<TodoItem>
    {
        public long  Id{ get; set; }

        public DeleteProductCommand(long id)
        {
            Id = id;
        }

    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TodoApi.Query
{
    public class GetOrderByIdQuery : IRequest<TodoItem>
    {
        public long Id { get; set; }

        public GetOrderByIdQuery(long id)
        {
            Id = id;
        }
    }

}
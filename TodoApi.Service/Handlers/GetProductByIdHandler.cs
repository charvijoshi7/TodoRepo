using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoApi.Query;
using TodoApi.Repository;
using TodoApi.Todo.Data.Repsoitories;

namespace TodoApi.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetOrderByIdQuery, TodoItem>
    {
        private readonly IProductRepsoitory _prdouctRepository;
        public GetProductByIdHandler(IProductRepsoitory productRepository)
        {
            _prdouctRepository = productRepository;

        }
        public async Task<TodoItem> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            TodoItem product = await _prdouctRepository.GetItemById(request.Id);
            return product;
        }
    }
}

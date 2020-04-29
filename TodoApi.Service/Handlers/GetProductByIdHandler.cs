using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoApi.Query;
using TodoApi.Repository;

namespace TodoApi.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetOrderByIdQuery, TodoItem>
    {
        private readonly IProductRepository _prdouctRepository;
        public GetProductByIdHandler(IProductRepository productRepository)
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

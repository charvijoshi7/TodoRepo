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
        private readonly ProductRepository _prdouctRepository;
        // private readonly IMapper _mapper;

        public GetProductByIdHandler(ProductRepository productRepository)
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

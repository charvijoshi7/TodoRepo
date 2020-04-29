using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoApi.Coomands;
using TodoApi.Repository;

namespace TodoApi.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, TodoItem>

    {
        private readonly IProductRepository _prdouctRepository;
        // private readonly IMapper _mapper;
        public DeleteProductHandler(IProductRepository productRepository)
        {
            _prdouctRepository = productRepository;

        }
        public async Task<TodoItem> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {

            TodoItem product = await _prdouctRepository.DeleteItem(request.Id);
            return product;
            }
    }
}

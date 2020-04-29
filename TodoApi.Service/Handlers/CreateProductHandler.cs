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
    public class CreateProductHandler: IRequestHandler<CreateProudctCommand ,TodoItem>
    {
        private readonly IProductRepository _productRepository;
       
        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }
        public async Task<TodoItem> Handle(CreateProudctCommand request, CancellationToken cancellationToken)
        {  
            TodoItem result =await _productRepository.AddProudct(request.Item);
             return result;
        }
    }
}

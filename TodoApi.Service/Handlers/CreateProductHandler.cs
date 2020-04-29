using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoApi.Coomands;
using TodoApi.Repository;
using TodoApi.Todo.Data.Repsoitories;

namespace TodoApi.Handlers
{
    public class CreateProductHandler: IRequestHandler<CreateProudctCommand ,TodoItem>
    {
        private readonly IProductRepsoitory _productRepository;
       
        public CreateProductHandler(IProductRepsoitory productRepository)
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

using AngleSharp.Common;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoApi.Query;  
using TodoApi.Repository;
using VDS.RDF;

namespace TodoApi.Handlers
{
    public class GetAllProductHandler : IRequestHandler<GetAllProudctDetail, List<TodoItem>>
    {

    private readonly ProductRepository _prdouctRepository;
       // private readonly IMapper _mapper;

        public GetAllProductHandler(ProductRepository productRepository)
        {
            _prdouctRepository = productRepository;
           
        }

        public async Task<List<TodoItem>> Handle(GetAllProudctDetail request, CancellationToken cancellationToken)
        {
            List<TodoItem> todoitem = await _prdouctRepository.GetAllitem();
            return todoitem;

            
        }
    } 
}

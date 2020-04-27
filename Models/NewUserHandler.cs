using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace TodoApi.Models
{
    public class NewUserHandler : IRequestHandler<NewUser, bool>
    {
       
        public Task<bool> Handle(NewUser request, CancellationToken cancellationToken)
        {
            // save to database  
            return Task.FromResult(true);
            throw new NotImplementedException();
        }
    }
}

using System;
//mediatr
using MediatR;
namespace TodoApi.Models
{
    public class NewUser: IRequest<bool>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}

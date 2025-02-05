using MediatR;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Requests.Queries
{
    public class GetProductByIdRequest : IRequest<List<Product>>
    {
        public int Id { get; set; }
    }
}

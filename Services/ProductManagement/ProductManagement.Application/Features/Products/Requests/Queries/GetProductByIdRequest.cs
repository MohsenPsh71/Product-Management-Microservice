using MediatR;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Requests.Queries
{
    public class GetProductByIdRequest : IRequest<Product>
    {
        public Guid Id { get; set; }
    }
}

using MediatR;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Requests.Queries
{
    public class GetAllProductsRequest : IRequest<List<Product>>
    {
    }
}

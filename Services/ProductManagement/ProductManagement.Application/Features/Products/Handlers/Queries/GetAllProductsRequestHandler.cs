using MediatR;
using ProductManagement.Application.Features.Products.Requests.Queries;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Handlers.Queries
{
    public class GetAllProductsRequestHandler : IRequestHandler<GetAllProductsRequest, List<Product>>
    {
        public Task<List<Product>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

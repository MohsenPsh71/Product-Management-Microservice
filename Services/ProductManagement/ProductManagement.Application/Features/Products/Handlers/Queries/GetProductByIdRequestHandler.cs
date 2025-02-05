using MediatR;
using ProductManagement.Application.Features.Products.Requests.Queries;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Handlers.Queries
{
    public class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, List<Product>>
    {
        public Task<List<Product>> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

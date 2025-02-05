using MediatR;

namespace ProductManagement.Application.Features.Products.Requests.Commands
{
    public class DeleteProductsCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

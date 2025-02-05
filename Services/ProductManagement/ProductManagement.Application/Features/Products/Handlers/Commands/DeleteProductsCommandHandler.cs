using MediatR;
using ProductManagement.Application.Features.Products.Requests.Commands;

namespace ProductManagement.Application.Features.Products.Handlers.Commands
{
    public class DeleteProductsCommandHandler : IRequestHandler<DeleteProductsCommand>
    {
        public Task Handle(DeleteProductsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

using MediatR;
using ProductManagement.Application.Features.Products.Requests.Commands;

namespace ProductManagement.Application.Features.Products.Handlers.Commands
{
    public class UpdateProductsCommandHandler : IRequestHandler<UpdateProductsCommand, Unit>
    {
        Task<Unit> IRequestHandler<UpdateProductsCommand, Unit>.Handle(UpdateProductsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

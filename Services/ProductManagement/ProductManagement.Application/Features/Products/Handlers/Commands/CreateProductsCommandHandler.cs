using MediatR;
using ProductManagement.Application.Features.Products.Requests.Commands;

namespace ProductManagement.Application.Features.Products.Handlers.Commands
{
    public class CreateProductsCommandHandler : IRequestHandler<CreateProductsCommand, int>
    {

        Task<int> IRequestHandler<CreateProductsCommand, int>.Handle(CreateProductsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

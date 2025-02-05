using MediatR;
using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Application.Exceptions;
using ProductManagement.Application.Features.Products.Requests.Commands;

namespace ProductManagement.Application.Features.Products.Handlers.Commands
{
    public class DeleteProductsCommandHandler : IRequestHandler<DeleteProductsCommand>
    {
        private readonly IProductsRepository _productsRepository;

        public DeleteProductsCommandHandler(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task Handle(DeleteProductsCommand request, CancellationToken cancellationToken)
        {
            var Product = await _productsRepository.GetByIdAsync(request.Id);

            if (Product == null)
                throw new NotFoundException(nameof(Product), request.Id);

            await _productsRepository.DeleteAsync(Product);
        }
    }
}

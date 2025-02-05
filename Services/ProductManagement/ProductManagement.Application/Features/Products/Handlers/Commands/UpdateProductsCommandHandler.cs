using AutoMapper;
using MediatR;
using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Application.Features.Products.Requests.Commands;

namespace ProductManagement.Application.Features.Products.Handlers.Commands
{
    public class UpdateProductsCommandHandler : IRequestHandler<UpdateProductsCommand, Unit>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public UpdateProductsCommandHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductsCommand request, CancellationToken cancellationToken)
        {
            var Products = await _productsRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, Products);
            await _productsRepository.UpdateAsync(Products);

            return Unit.Value;
        }
    }
}

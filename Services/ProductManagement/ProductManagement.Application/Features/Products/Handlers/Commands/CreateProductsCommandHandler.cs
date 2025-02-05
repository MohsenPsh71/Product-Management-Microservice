using AutoMapper;
using MediatR;
using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Application.Features.Products.Requests.Commands;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Handlers.Commands
{
    public class CreateProductsCommandHandler : IRequestHandler<CreateProductsCommand, Guid>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public CreateProductsCommandHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateProductsCommand request, CancellationToken cancellationToken)
        {
            var Products = _mapper.Map<Product>(request);
            var ProductsId = await _productsRepository.AddAsync(Products);
            return ProductsId.Id;
        }
    }
}

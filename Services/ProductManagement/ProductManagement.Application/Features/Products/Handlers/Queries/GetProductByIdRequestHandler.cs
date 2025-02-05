using AutoMapper;
using MediatR;
using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Application.Features.Products.Requests.Queries;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Handlers.Queries
{
    public class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, Product>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public GetProductByIdRequestHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }
        public async Task<Product> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
        {
            var Product = await _productsRepository
               .GetAllProductsById(request.Id);
            return _mapper.Map<Product>(Product);
        }
    }
}

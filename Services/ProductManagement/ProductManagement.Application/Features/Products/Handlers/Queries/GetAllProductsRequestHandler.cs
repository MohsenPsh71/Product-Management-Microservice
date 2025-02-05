using AutoMapper;
using MediatR;
using ProductManagement.Application.Contracts.Persistence;
using ProductManagement.Application.Features.Products.Requests.Queries;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Features.Products.Handlers.Queries
{
    public class GetAllProductsRequestHandler : IRequestHandler<GetAllProductsRequest, List<Product>>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public GetAllProductsRequestHandler(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<List<Product>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            var Product = await _productsRepository
               .GetAllProducts();
            return _mapper.Map<List<Product>>(Product);
        }
    }
}

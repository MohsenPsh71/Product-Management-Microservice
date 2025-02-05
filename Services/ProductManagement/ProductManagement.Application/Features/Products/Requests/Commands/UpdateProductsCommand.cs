
using MediatR;

namespace ProductManagement.Application.Features.Products.Requests.Commands
{
    internal class UpdateProductsCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}


using MediatR;

namespace ProductManagement.Application.Features.Products.Requests.Commands
{
    public class UpdateProductsCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}

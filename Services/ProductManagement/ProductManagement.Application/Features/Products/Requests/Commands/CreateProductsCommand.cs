using MediatR;

namespace ProductManagement.Application.Features.Products.Requests.Commands
{
    public class CreateProductsCommand: IRequest<Guid>
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}

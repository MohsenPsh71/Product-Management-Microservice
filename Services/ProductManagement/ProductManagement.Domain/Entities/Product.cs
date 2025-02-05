using ProductManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Domain.Entities
{
    public class Product:EntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

    }
}

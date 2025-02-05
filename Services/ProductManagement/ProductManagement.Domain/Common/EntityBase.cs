using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Common
{
    public class EntityBase
    {
        public int Id { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreateDate { get; set; }

        public string? LastModifiedBy { get; set; } = "mohsen";

        public DateTime? ModifiedDate { get; set; }
    }
}

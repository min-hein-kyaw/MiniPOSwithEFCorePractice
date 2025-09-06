using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    [Table("Table_Product")]
    public class ProductDTO
    {
        [Key]

        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public bool DeleteFlag { get; set; }
    }
}

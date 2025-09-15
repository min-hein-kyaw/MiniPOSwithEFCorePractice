using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    [Table("Table_SaleDetail")]
    [Keyless]
    public class SaleDetailDTO
    {
        [Column("SaleId")]
        public int SaleId {  get; set; }

        [Column("ProductId")]
        public required string ProductId { get; set; }

        [Column("Quantity")]
        public int Quantity {  get; set; }

        [Column("Price")]
        public decimal Price { get; set; }
    }
}

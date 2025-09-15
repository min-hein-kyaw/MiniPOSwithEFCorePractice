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
    public class SaleDetailDTO
    {
        public int SaleId {  get; set; }

        [Key]
        public string ProductId { get; set; }

        public int Quantity {  get; set; }

        public decimal Price { get; set; }
    }
}

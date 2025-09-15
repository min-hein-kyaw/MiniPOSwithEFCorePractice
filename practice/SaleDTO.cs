using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    [Table("Table_Sale")]
    public class SaleDTO
        
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SaleId { get; set; }
       
        
        public string VoucherNo { get; set; }

        public DateTime SaleDate {  get; set; }

        public decimal TotalAmount { get; set; }
    }
}

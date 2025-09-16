using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    [Table("Table_User")]
    public class UserDTO
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
    }
}

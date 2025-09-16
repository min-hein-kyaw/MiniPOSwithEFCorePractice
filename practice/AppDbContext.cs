using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder() { 
            
                DataSource = ".",
                InitialCatalog = "MHKDotNetTrainingInPersonBatch1POS",
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true,

            };
            optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
        }

        


        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<SaleDTO> Sale { get; set; }
        public DbSet<SaleDetailDTO> SaleDetail { get; set; }

        public DbSet<UserDTO> User { get; set; }
    }
}

using CarVendor.Models;
using Microsoft.EntityFrameworkCore;

namespace CarVendor.Data
{
    public class CarVendorContext : DbContext
    {
        public DbSet<Car> Cars { get; set;}
        public DbSet<Customer> Customers { get; set;}

        public CarVendorContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}

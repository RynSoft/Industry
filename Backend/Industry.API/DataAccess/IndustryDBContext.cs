using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Industry.API.DataAccess;

public class IndustryDBContext:DbContext
{
    public IndustryDBContext(DbContextOptions<IndustryDBContext> options):base(options) {  }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
}
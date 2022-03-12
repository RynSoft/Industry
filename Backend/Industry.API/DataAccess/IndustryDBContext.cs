using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Industry.API.DataAccess;

public class IndustryDBContext:DbContext
{
    public IndustryDBContext(DbContextOptions<IndustryDBContext> options):base(options) {  }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Product> Product { get; set; }
}
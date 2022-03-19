using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Industry.API.DataAccess;

public class IndustryDBContext:DbContext
{
    public IndustryDBContext(DbContextOptions<IndustryDBContext> options):base(options) {  }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Offers> Offers { get; set; }
    public DbSet<OfferProducts> OfferProducts { get; set; }
    
}
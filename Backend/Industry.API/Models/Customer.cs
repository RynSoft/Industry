
namespace Industry.API
{
    public class Customer : BaseFullModel<Guid>
    {
        public Customer()
        {
            Product = new();
        }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? TaxId { get; set; }
        public string? TaxOffice { get; set; }
        public string? Phone { get; set; }
        public string? OfficerName { get; set; }
        //public CustomerType CustomerType { get; set; }
        public string? Explanation { get; set; }
        public virtual HashSet<Product> Product { get; set; }

    }
}

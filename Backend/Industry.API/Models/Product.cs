using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class Product : BaseFullModel<Guid>
    {
        public Product()
        {
        }
        public string ProductName { get; set; }
        public string? ProductNumber { get; set; }
        public double? Quantity { get; set; }
        public string? ShelfNo { get; set; }
        public string? Explanation { get; set; }
        public byte[] Image { get; set; }
        // public Guid CustomerId { get; set; }
        // [ForeignKey("CustomerId")]
        // public virtual Customer Customer { get; set; }
        public Guid? UnitId { get; set; }
        // [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }
    }
}

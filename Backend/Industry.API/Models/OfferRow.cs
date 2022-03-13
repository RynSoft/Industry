
using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class OfferRow : BaseFullModel<Guid>
    {
        public OfferRow()
        {
            Product = new();
            OfferHead = new();
            
        }
        public double? Quantity { get; set; }
        public string? Explanation { get; set; }
        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public Guid OfferHeadId { get; set; }
        [ForeignKey("OfferHeadId")]
        public virtual OfferHead OfferHead{ get; set; }
        

    }
}

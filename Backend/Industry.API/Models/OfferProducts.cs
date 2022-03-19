
using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class OfferProducts : BaseFullModel<Guid>
    {
        public OfferProducts()
        {
            Product = new();
            Offers = new();
            OrderTitles = new();
            WorkOrder = new();
        }
        public double? Quantity { get; set; }
        public string? Explanation { get; set; }
        public Guid ProductId { get; set; }
        public Guid OfferId { get; set; }
        public string status { get; set; } // IN_OFFER, IN_PRODUCE, DONE
        public Guid OrderTitlesId { get; set; }
        public Guid CurrentWorkOrderId { get; set; }
        
        
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        
        [ForeignKey("OrderTitlesId")]
        public virtual OrderTitles OrderTitles{ get; set; }
        
        [ForeignKey("OffersId")]
        public virtual Offers Offers{ get; set; }

        [ForeignKey("WorkOrderId")]
        public virtual WorkOrder WorkOrder{ get; set; }

    }
}

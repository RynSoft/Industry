
using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class Offers : BaseFullModel<Guid>
    {
        public Offers()
        {
            Customer = new();
        }
        public string  OfferNo { get; set; } // teklif no 
        public DateOnly OfferSentDate { get; set; }
        public string? Explanation { get; set; }
        public Guid CustomerId { get; set; }
        public double Price { get; set; }
        public string status { get; set; } // draft, sent, accepted, rejected
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

    }
}

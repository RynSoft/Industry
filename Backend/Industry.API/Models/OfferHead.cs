
using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class OfferHead : BaseFullModel<Guid>
    {
        public OfferHead()
        {
            Customer = new();
        }
        public int  Number { get; set; }
        public DateOnly Date { get; set; }
        public string? Explanation { get; set; }
        public Guid CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

    }
}

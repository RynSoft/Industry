
using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class WorkOrder : BaseFullModel<Guid>
    {
        public WorkOrder()
        {
            OrdeerTitles = new OrderTitles();
        }
        
        public Guid OrderTitleId { get; set; }
        public string Title { get; set; }
        public int RowNo { get; set; }
        
        [ForeignKey("OrderTitlesId")]
        public virtual OrderTitles OrdeerTitles { get; set; }
    }
}

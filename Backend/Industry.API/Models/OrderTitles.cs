
using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class OrderTitles : BaseFullModel<Guid>
    {
        public OrderTitles()
        {
        }
        
        public string title { get; set; }
        public Boolean IsTemplate { get; set; }
    }
}

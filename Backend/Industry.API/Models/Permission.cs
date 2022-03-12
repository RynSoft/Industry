

namespace Industry.API
{

    public class Permission : BaseSimpleModel<Guid>
    {

        public string Name { get; set; }
        public string? Description { get; set; }

    }
}

using System;

namespace Industry.API
{
    public interface IBaseFullModel<T>
    {
        T Id { get; set; }
        DateTime? CreateDate { get; set; }
        Guid? CreatorId { get; set; }
        DateTime? EditDate { get; set; }
        Guid? EditorId { get; set; }
     
    }
}

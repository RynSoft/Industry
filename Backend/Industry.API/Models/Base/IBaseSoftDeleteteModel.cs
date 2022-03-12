using System;

namespace Industry.API
{
    public interface IBaseSoftDeleteteModel<T> : IBaseFullModel<T>
    {
        DateTime? DeleteDate { get; set; }
        bool IsDeleted { get; set; }
    }
}

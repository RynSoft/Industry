using System;

namespace Industry.API
{
    public interface IBaseSimpleModel<T>
    {
        T Id { get; set; }
        DateTime? CreateDate { get; set; }
     
    }
}

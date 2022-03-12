using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Industry.API
{
    public class BaseSimpleModel<T> : IBaseSimpleModel<T>
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime? CreateDate { get; set; }

    }
}

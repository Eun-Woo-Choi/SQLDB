using CMS.Entity.Enums;
using System;

namespace CMS.Entity.Entities.Interface
{
    public interface IBaseEntity
    {
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; }
    }
}


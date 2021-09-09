using CMS.Entity.Entities.Interface;
using CMS.Entity.Enums;
using System;
using System.Collections.Generic;

namespace CMS.Entity.Entities.Concrete
{
    public class Profile : IBaseEntity
    {
        public int ProfileId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }

        /*
         One-to-One Relationship with AppUser Table
         */
        public virtual AppUser AppUsers { get; set; }
    }
}


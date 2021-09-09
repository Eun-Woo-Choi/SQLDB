using CMS.Entity.Entities.Interface;
using CMS.Entity.Enums;
using System;
using System.Collections.Generic;

namespace CMS.Entity.Entities.Concrete
{
    public class Comment : IBaseEntity
    {
        public int CommentId { get; set; }
        public string Description { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }

        /*
         One-to-Many Relationship with Article Table
         */
        public virtual List<Article> Articles { get; set; }
    }
}


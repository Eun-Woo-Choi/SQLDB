using CMS.Entity.Entities.Interface;
using CMS.Entity.Enums;
using System;

namespace CMS.Entity.Entities.Concrete
{
    public class Article : IBaseEntity
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }

        /* 
          One-to-Many Relationship
         */
        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}


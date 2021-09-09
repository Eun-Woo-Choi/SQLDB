using CMS.Entity.Entities.Interface;
using CMS.Entity.Enums;
using System;

namespace CMS.Entity.Entities.Concrete
{
    public class Page : IBaseEntity
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public int? Sorting { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}



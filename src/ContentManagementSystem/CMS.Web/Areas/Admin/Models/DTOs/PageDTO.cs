using System.ComponentModel.DataAnnotations;

namespace CMS.Web.Areas.Admin.Models.DTOs
{
    public class PageDTO
    {
        [Required(ErrorMessage = "Please, type into page title.")]
        [MinLength(3, ErrorMessage = "Please, minimum lenght is 3.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, type into page title.")]
        [MinLength(3, ErrorMessage = "Please, minimum lenght is 3.")]
        public string Content { get; set; }

        public string Slug => Title.ToLower().Replace(' ', '-');
    }
}

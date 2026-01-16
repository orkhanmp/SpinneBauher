using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.PageBannerDTOs
{
    public class UpdatePageBannerDto
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string Title { get; set; }
        public string Breadcrumb { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string BackgroundColor { get; set; }
        public bool IsActive { get; set; }
    }
}

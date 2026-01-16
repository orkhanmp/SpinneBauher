using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.ProjectDTOs
{
    public class ProjectDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string DetailedDescription { get; set; }
        public string Location { get; set; }
        public string ClientName { get; set; }
        public decimal? Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public string MainImageUrl { get; set; }
        public List<string> GalleryImages { get; set; }
        public int ProjectCategoryId { get; set; }
        public string ProjectCategoryName { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

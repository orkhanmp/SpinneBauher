using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.ServiceDTOs
{
    public class UpdateServiceDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string DetailedDescription { get; set; }
        public string ImageUrl { get; set; }
        public string IconClass { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}

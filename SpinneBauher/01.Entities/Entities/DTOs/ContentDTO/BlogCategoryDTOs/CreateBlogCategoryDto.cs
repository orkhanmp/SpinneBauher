using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.BlogCategoryDTOs
{
    public class CreateBlogCategoryDto
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}

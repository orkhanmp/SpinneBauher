using Entities.DTOs.ContentDTO.ServiceDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.ServiceCategoryDTOs
{
    public class ServiceCategoryDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<ServiceDto> Services { get; set; }
    }
}

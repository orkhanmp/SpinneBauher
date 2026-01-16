using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.TeamMamberDTOs
{
    public class TeamMemberDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public int? TeamCategoryId { get; set; }
        public string TeamCategoryName { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

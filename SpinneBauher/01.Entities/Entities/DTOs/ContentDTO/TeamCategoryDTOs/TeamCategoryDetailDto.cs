using Entities.DTOs.ContentDTO.TeamMamberDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.TeamCategoryDTOs
{
    public class TeamCategoryDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<TeamMemberDto> TeamMembers { get; set; }
    }
}

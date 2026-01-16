using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.TeamMamberDTOs
{
    public class CreateTeamMemberDto
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string InstagramUrl { get; set; }
        public int? TeamCategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}

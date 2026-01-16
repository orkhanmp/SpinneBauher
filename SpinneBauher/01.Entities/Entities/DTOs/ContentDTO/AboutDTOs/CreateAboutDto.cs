using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.AboutDTOs
{
    public class CreateAboutDto
    {
        public string SubTitle { get; set; }
        public string MainHeading { get; set; }
        public string Description { get; set; }
        public string SecondDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ButtonText { get; set; }
        public string ButtonUrl { get; set; }
        public int ExpertWorkers { get; set; }
        public int HappyClients { get; set; }
        public int CompletedProjects { get; set; }
        public int RunningProjects { get; set; }
    }
}

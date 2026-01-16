using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.HomeSliderDTOs
{
    public class UpdateHomeSliderDto
    {
        public int Id { get; set; }
        public string SubTitle { get; set; }
        public string MainHeading { get; set; }
        public string ButtonText { get; set; }
        public string ButtonUrl { get; set; }
        public string BackgroundImageUrl { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}

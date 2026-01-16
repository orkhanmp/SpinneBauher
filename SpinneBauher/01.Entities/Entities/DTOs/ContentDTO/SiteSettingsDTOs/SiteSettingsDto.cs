using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.SiteSettingsDTOs
{
    public class SiteSettingsDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string LogoUrl { get; set; }
        public string FaviconUrl { get; set; }
        public string OpeningHours { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string YouTubeUrl { get; set; }
        public string GoogleMapEmbedUrl { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

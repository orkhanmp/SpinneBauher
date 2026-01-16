using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels.Content
{
    public class HomeSlider:BaseEntity
    {
        public string Title { get; set; } 
        public string Heading { get; set; } 
        public string Description { get; set; }
        public string ButtonText { get; set; } 
        public string ButtonUrl { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        
    }
}

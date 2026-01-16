using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels.Content
{
    public class ServiceCategory: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Service> Services { get; private set; } = new List<Service>();
    }
}

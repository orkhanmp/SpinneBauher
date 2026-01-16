using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels.Content
{
    public class ProjectCategory: BaseEntity
    {
        public string Name { get; set; } 
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Project> Projects { get; private set; } = new List<Project>();
    }
}

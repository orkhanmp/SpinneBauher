using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Deleted { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

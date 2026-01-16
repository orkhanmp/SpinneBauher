using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels.Content
{
    public class ContactSubmission:BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public bool IsReplied { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
    }
}

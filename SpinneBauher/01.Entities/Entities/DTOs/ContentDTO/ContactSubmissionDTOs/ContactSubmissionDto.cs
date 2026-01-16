using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.ContactSubmissionDTOs
{
    public class ContactSubmissionDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public bool IsReplied { get; set; }
        public DateTime SubmittedDate { get; set; }
    }
}

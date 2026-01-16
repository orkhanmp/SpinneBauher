using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.ContactSubmissionDTOs
{
    public class UpdateContactSubmissionDto
    {
        public int Id { get; set; }
        public bool IsRead { get; set; }
        public bool IsReplied { get; set; }
    }
}

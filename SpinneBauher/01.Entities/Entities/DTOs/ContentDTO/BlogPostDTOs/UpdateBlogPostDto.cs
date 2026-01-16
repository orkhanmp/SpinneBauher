using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.ContentDTO.BlogPostDTOs
{
    public class UpdateBlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public int BlogCategoryId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishDate { get; set; }
        public string Tags { get; set; }
    }
}

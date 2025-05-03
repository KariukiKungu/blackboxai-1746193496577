using System;
using System.ComponentModel.DataAnnotations;

namespace saas_blog_shop.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}

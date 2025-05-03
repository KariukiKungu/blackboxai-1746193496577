using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace saas_blog_shop.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}

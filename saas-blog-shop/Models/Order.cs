using System;
using System.Collections.Generic;

namespace saas_blog_shop.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BidStream.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public ICollection<Item> Items { get; set; } = new HashSet<Item>();
    }
}

using BidStream.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BidStream.Domain.Entities
{
    public class Item : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public ItemCondition Condition { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}

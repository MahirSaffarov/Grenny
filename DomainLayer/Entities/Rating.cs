using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Rating : BaseEntity
    {
        public byte RatingCount { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

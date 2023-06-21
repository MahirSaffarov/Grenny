using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Wishlist : BaseEntity
    {
        public ICollection<UserWishlist> UserWishlists { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public ICollection<UserBasket> UserBaskets { get; set; }
        public ICollection<UserWishlist> UserWishlists { get; set; }

    }
}

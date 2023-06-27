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
        public bool IsBlock { get; set; } = false;
        public Basket Basket { get; set; }
        public Wishlist Wishlist { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}

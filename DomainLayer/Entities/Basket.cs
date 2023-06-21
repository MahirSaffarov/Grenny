using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Basket : BaseEntity
    {
        public ICollection<UserBasket> UserBaskets { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

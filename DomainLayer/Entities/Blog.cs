using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Blog : BaseEntity  
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}

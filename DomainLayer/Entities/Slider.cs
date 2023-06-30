using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Slider : BaseEntity
    {
        public string Image { get; set; }
        public bool Status { get; set; } = true;
    }
}

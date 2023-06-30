using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class SliderInfo : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}

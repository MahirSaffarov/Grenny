using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Review : BaseEntity
    {
        public string Describe { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        [ForeignKey("Rating")]
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
    }
}

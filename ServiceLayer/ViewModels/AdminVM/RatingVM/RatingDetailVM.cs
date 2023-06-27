using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.RatingVM
{
    public class RatingDetailVM
    {
        public int Id { get; set; }
        public byte RatingCount { get; set; }
        public string CreateDate { get; set; }
    }
}

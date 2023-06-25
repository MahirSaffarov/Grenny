using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.ProductVM
{
    public class CheckBoxVM
    {
        public int Id { get; set; }
        public string LabelName { get; set; }
        public bool IsChecked { get; set; }
    }
}

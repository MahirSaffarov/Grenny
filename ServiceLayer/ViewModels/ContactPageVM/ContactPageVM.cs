using ServiceLayer.ViewModels.City;
using ServiceLayer.ViewModels.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.ContactPageVM
{
    public class ContactPageVM
    {
        public IEnumerable<CityVM> CityVM { get; set; }
        public IEnumerable<ContactVM> ContactVM { get; set; }
    }
}

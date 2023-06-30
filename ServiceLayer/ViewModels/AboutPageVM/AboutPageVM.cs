using ServiceLayer.ViewModels.Service;
using ServiceLayer.ViewModels.Social;
using ServiceLayer.ViewModels.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AboutPageVM
{
    public class AboutPageVM
    {
        public IEnumerable<TeamVM> TeamVM { get; set; }
        public IEnumerable<SocialVM> SocialVM { get; set; }
        public IEnumerable<ServiceVM> ServiceVM { get; set; }
    }
}

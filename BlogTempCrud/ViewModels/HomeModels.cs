using BlogTempCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTempCrud.ViewModels
{
    public class HomeModels
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<BlogData> BlogDatas { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}


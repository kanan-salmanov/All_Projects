using BlogTempCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTempCrud.ViewModels
{
    public class UserStatusModels
    {
        public User Users { get; set; }
        public ICollection<Status> Statuses { get; set; }
    }
}

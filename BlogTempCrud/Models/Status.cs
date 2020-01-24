using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTempCrud.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string StatusName { get; set; }
        [Required, StringLength(500)]
        public string StatusDescription { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

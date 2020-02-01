using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTempCrud.Models
{
    public class User 
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required, StringLength(200)]
        public string Lastname { get; set; }
        [Required, StringLength(200)]
        public string Email { get; set; }
        [Required, StringLength(200)]
        public string Password { get; set; }

        public  List<BlogData> BlogDatas { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

    }
}

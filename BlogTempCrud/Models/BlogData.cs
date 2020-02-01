using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTempCrud.Models
{
    public class BlogData
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required, StringLength(250)]
        public string Image { get; set; }
        [Required]
        public DateTime Time { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

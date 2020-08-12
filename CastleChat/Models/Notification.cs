using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class Notification
    {
        public long id { get; set; }
        [Required]
        public string text { get; set; }
        [Required]
        public DateTime date { get; set; } = DateTime.Now;
        [Required]
        public User user { get; set; }
        public string? address { get; set; }
        [Required]
        public bool isChecked { get; set; } = false;
    }
}

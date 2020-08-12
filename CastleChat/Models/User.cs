using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class User
    {
        public long id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public DateTime regDate { get; set; } = DateTime.Now;
        [Required]
        public string icon { get; set; } = "/Default.png";
        [Required]
        public string token { get; set; }
        [Required]
        public string role { get; set; } = Role.USER;
        public List<Discussion> discussions { get; set; }
        public List<Room> rooms { get; set; }
    }
}

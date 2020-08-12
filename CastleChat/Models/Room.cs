using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class Room
    {
        public long id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string text { get; set; }
        [Required]
        public User author { get; set; }
        [Required]
        public Castle castle { get; set; }
        [Required]
        public DateTime pubDate { get; set; } = DateTime.Now;
        public string? filePath { get; set; }
        public List<Discussion> discussions { get; set; }
    }
}

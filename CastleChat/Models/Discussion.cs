using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class Discussion
    {
        public long id { get; set; }
        [Required]
        public string text { get; set; }
        [Required]
        public User author { get; set; }
        public List<DiscussionReply> replies { get; set; }
        [Required]
        public DateTime pubDate { get; set; } = DateTime.Now;
        public string? filePath { get; set; }
        [Required]
        public Room room { get; set; }
    }
}

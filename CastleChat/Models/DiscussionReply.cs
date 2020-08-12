using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class DiscussionReply : Discussion
    {
        [Required]
        public Discussion discussion { get; set; }
    }
}

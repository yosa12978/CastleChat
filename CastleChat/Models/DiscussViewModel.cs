using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class DiscussViewModel
    {
        public IEnumerable<Discussion> discussions { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

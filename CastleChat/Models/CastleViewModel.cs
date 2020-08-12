using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class CastleViewModel
    {
        public IEnumerable<Castle> castles { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

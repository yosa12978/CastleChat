using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class RoomViewModel
    {
        public IEnumerable<Room> rooms { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

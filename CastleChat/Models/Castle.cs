using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Models
{
    public class Castle
    {
        public long id { get; set; }
        [Required]
        public string title { get; set; }
        public List<Room> rooms { get; set; }
    }
}

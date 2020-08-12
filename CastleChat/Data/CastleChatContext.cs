using CastleChat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Data
{
    public class CastleChatContext : DbContext
    {
        public ILogger<CastleChatContext> _logger;
        public CastleChatContext(DbContextOptions<CastleChatContext> option, ILogger<CastleChatContext> logger) : base(option)
        {
            _logger = logger;
        }

        public DbSet<User> users { get; set; }
        public DbSet<Castle> castles { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Discussion> discussions { get; set; }
        public DbSet<DiscussionReply> discussionReplies { get; set; }
        public DbSet<Notification> notifications { get; set; }
    }
}

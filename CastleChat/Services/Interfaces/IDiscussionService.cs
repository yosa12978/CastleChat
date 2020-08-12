using CastleChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Services.Interfaces
{
    public interface IDiscussionService
    {
        void AddDiscussion(string text, string username, long roomid, string? path);
        long AddReply(string text, string username, long roomid, long discussionid, string? path);
        DiscussViewModel GetDiscussions(long roomid, int page);
        Discussion GetDiscussion(long id);
    }
}

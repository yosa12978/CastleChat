using CastleChat.Data;
using CastleChat.Models;
using CastleChat.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Services.Mocks
{
    public class DiscussionService : IDiscussionService
    {
        private readonly CastleChatContext _db;
        public DiscussionService(CastleChatContext db)
        {
            _db = db;
        }

        public void AddDiscussion(string text, string username, long roomid, string? path)
        {
            string? finalpath = null;
            if (path != null)
                finalpath = path;
            Discussion discussion = new Discussion
            {
                text = text,
                author = _db.users.FirstOrDefault(m => m.username == username),
                room = _db.rooms.FirstOrDefault(m => m.id == roomid),
                filePath = finalpath
            };
            _db.discussions.Add(discussion);
            _db.SaveChanges();
        }

        public long AddReply(string text, string username, long roomid, long discussionid, string? path)
        {
            string? finalpath = null;
            if (path != null)
                finalpath = path;
            DiscussionReply discussion = new DiscussionReply
            {
                text = text,
                author = _db.users.FirstOrDefault(m => m.username == username),
                room = _db.rooms.FirstOrDefault(m => m.id == roomid),
                discussion = _db.discussions.FirstOrDefault(m => m.id == discussionid),
                filePath = finalpath
            };
            _db.discussionReplies.Add(discussion);
            _db.SaveChanges();

            return discussion.id;
        }

        public Discussion GetDiscussion(long id)
        {
            return _db.discussions
                .Include(m => m.room)
                .Include(m => m.author)
                .FirstOrDefault(m => m.id == id);
        }

        public DiscussViewModel GetDiscussions(long roomid, int page)
        {

            int pageSize = 20;
            IQueryable<Discussion> source = _db.discussions
                                        .Include(m => m.room)
                                        .Include(m => m.author)
                                        .Where(m => m.room.id == roomid)
                                        .OrderBy(m => m.id);

            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            DiscussViewModel viewModel = new DiscussViewModel
            {
                PageViewModel = pageViewModel,
                discussions = items
            };
            return viewModel;
        }
    }
}

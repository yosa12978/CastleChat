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
    public class RoomService : IRoomService
    {
        private readonly CastleChatContext _db;
        private readonly ILogger<RoomService> _logger;
        public RoomService(CastleChatContext db, ILogger<RoomService> logger) 
        {
            _db = db;
            _logger = logger;
        }

        public void CreateRoom(string text, string title, string username, long castleid, string? path)
        {
            string? finalpath = null;
            if (path != null) 
                finalpath = path;

            Room room = new Room
            {
                text = text,
                author = _db.users.FirstOrDefault(m => m.username == username),
                title = title,
                castle = _db.castles.FirstOrDefault(m => m.id == castleid),
                filePath = finalpath
            };
            _db.rooms.Add(room);
            _db.SaveChanges();
        }

        public Room GetRoom(long roomid)
        {
            return _db.rooms
                .Include(m => m.author)
                .Include(m => m.discussions)
                .FirstOrDefault(m => m.id == roomid);
        }

        public RoomViewModel GetRooms(long castleid, int page)
        {
            int pageSize = 50;
            IQueryable<Room> source = _db.rooms
                                    .Include(m => m.castle)
                                    .Include(m => m.author)
                                    .Include(m => m.discussions)
                                    .Where(m => m.castle.id == castleid)
                                    .OrderByDescending(m => m.id);

            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            RoomViewModel viewModel = new RoomViewModel
            {
                PageViewModel = pageViewModel,
                rooms = items
            };
            return viewModel;
        }

        public RoomViewModel Search(string query, int page)
        {
            int pageSize = 20;
            IQueryable<Room> source = _db.rooms
                                    .Include(m => m.castle)
                                    .Include(m => m.author)
                                    .Include(m => m.discussions)
                                    .Where(m => m.title.Contains(query))
                                    .OrderByDescending(m => m.id);

            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            RoomViewModel viewModel = new RoomViewModel
            {
                PageViewModel = pageViewModel,
                rooms = items
            };
            return viewModel;
        }
    }
}

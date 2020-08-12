using CastleChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Services.Interfaces
{
    public interface IRoomService
    {
        Room GetRoom(long roomid);
        RoomViewModel GetRooms(long castleid, int page);
        void CreateRoom(string text, string title, string username, long castleid, string? path);
        RoomViewModel Search(string query, int page);
    }
}

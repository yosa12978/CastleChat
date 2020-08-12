using CastleChat.Data;
using CastleChat.Models;
using CastleChat.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Services.Mocks
{
    public class CastleService : ICastleService
    {
        private readonly CastleChatContext _db;
        public CastleService(CastleChatContext db)
        {
            _db = db;
        }
        public Castle GetCastle(long castleid)
        {
            return _db.castles
                .Include(m => m.rooms)
                .FirstOrDefault(m => m.id == castleid);
        }

        public List<Castle> GetCastles()
        {
            return _db.castles
                .OrderBy(m => m.title)
                .ToList();
        }

        public bool isCastleExist(long id)
        {
            return _db.castles.Any(m => m.id == id);
        }
    }
}

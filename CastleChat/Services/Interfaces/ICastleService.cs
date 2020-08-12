using CastleChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Services.Interfaces
{
    public interface ICastleService
    {
        Castle GetCastle(long castleid);
        List<Castle> GetCastles();
        bool isCastleExist(long id);
    }
}

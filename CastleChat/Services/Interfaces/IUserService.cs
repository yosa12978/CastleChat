using CastleChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CastleChat.Services.Interfaces
{
    public interface IUserService
    {
        ClaimsPrincipal Authenticate(string username, string password);
        string ComputeHash(string rawData);
        void Signup(string username, string password);
        bool isUserExist(string username, string password);
        bool isUsernameExist(string username);
        User GetUser(string username);
        void addIcon(string path, string username);
    }
}

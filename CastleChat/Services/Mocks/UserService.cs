using CastleChat.Data;
using CastleChat.Models;
using CastleChat.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CastleChat.Services.Mocks
{
    public class UserService : IUserService
    {
        private readonly CastleChatContext _db;
        public UserService(CastleChatContext db)
        {
            _db = db;
        }

        public void addIcon(string path, string username)
        {
            User user = _db.users.FirstOrDefault(m => m.username == username);
            user.icon = path;
            _db.SaveChanges();
        }

        public ClaimsPrincipal Authenticate(string username, string password)
        {
            string hashed_Password = ComputeHash(password);
            User user = _db.users
                .FirstOrDefault(m => m.username == username && m.password == hashed_Password);
            if (user == null)
                return null;
            List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Name, user.username), new Claim(ClaimTypes.Role, user.role) };
            ClaimsIdentity identity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            return principal;
        }

        public string ComputeHash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }

        public User GetUser(string username)
        {
            return _db.users
                .Include(m => m.rooms)
                .Include(m => m.discussions)
                .FirstOrDefault(m => m.username == username); 
        }

        public bool isUserExist(string username, string password)
        {
            return _db.users
                .Any(m => m.username == username && m.password == password);
        }

        public bool isUsernameExist(string username)
        {
            return _db.users
                .Any(m => m.username == username);
        }

        public void Signup(string username, string password)
        {
            User user = new User
            {
                username = username,
                password = ComputeHash(password),
                token = ComputeHash(username+DateTime.Now.ToString())
            };
            _db.users.Add(user);
            _db.SaveChanges();
        }
    }
}

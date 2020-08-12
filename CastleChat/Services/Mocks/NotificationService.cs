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
    public class NotificationService : INotificationService
    {
        public readonly CastleChatContext _db;
        public NotificationService(CastleChatContext db)
        {
            _db = db;
        }

        public Notification GetNotification(long id)
        {
            return _db.notifications
                .Include(m => m.user)
                .FirstOrDefault(m => m.id == id);
        }

        public void CheckNotification(long id)
        {
            Notification notification = _db.notifications.FirstOrDefault(m => m.id == id);
            notification.isChecked = true;
            _db.SaveChanges();
        }

        public void CreateNotification(string text, string username, string address)
        {
            Notification notification = new Notification
            {
                text = text,
                user = _db.users.FirstOrDefault(m => m.username == username),
                address = address
            };
            _db.notifications.Add(notification);
            _db.SaveChanges();
        }

        public void DeleteNotification(long id)
        {
            Notification notification = _db.notifications.FirstOrDefault(m => m.id == id);
            _db.notifications.Remove(notification);
            _db.SaveChanges();
        }

        public List<Notification> GetNotifications(string username)
        {
            return _db.notifications
                .Where(m => m.user.username == username)
                .ToList();
        }

        public bool isNotificationExist(long id, string username)
        {
            return _db.notifications
                .Any(m => m.id == id && m.user.username == username);
        }
    }
}

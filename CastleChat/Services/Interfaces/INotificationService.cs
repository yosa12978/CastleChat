using CastleChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CastleChat.Services.Interfaces
{
    public interface INotificationService
    {
        void CreateNotification(string text, string username, string? address);
        List<Notification> GetNotifications(string username);
        void DeleteNotification(long id);
        bool isNotificationExist(long id, string username);
        void CheckNotification(long id);
        Notification GetNotification(long id);
    }
}

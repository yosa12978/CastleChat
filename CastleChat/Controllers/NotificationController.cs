using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CastleChat.Models;
using CastleChat.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CastleChat.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService; 
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Notification> notifications = _notificationService.GetNotifications(HttpContext.User.Identity.Name);
            return View(notifications);
        }

        [HttpGet]
        public IActionResult Check(long id)
        {
            // TODO: REFACTOR
            bool isNotifyExist = _notificationService.isNotificationExist(id, HttpContext.User.Identity.Name);
            if (!isNotifyExist)
                return NotFound();
            _notificationService.CheckNotification(id);
            Notification notification = _notificationService.GetNotification(id);
            if (notification.address == null)
                return NotFound();
            return Redirect(notification.address);
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            bool isNotificationExist = _notificationService.isNotificationExist(id, HttpContext.User.Identity.Name);
            if (!isNotificationExist)
                return NotFound();
            _notificationService.DeleteNotification(id);
            return Redirect("/Notification/");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CastleChat.Models;
using CastleChat.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CastleChat.Controllers
{
    public class RoomController : Controller
    {
        private readonly ILogger<RoomController> _logger;
        private readonly IRoomService _roomService;
        private readonly IUserService _userService;
        private readonly IDiscussionService _discussionService;
        private readonly ICastleService _castleService;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly INotificationService _notificationService;
        public RoomController(ILogger<RoomController> logger, 
            IRoomService roomService, 
            IUserService userService, 
            IDiscussionService discussionService, 
            ICastleService castleService, 
            IWebHostEnvironment appEnvironment,
            INotificationService notificationService)
        {
            _logger = logger;
            _roomService = roomService;
            _userService = userService;
            _castleService = castleService;
            _discussionService = discussionService;
            _appEnvironment = appEnvironment;
            _notificationService = notificationService;
        }

        [HttpGet]
        [Route("/Room/{id}")]
        [ResponseCache(Duration = 1)]
        public IActionResult Index([FromRoute]long id, int page = 1)
        {
            RoomViewModel rooms = _roomService.GetRooms(id, page);
            ViewBag.ParentCastle = _castleService.GetCastle(id);
            return View(rooms);
        }

        [HttpGet]
        [ResponseCache(Duration = 1)]
        public IActionResult Detail(long id, int page = 1)
        {
            Room room = _roomService.GetRoom(id);
            DiscussViewModel discussions = _discussionService.GetDiscussions(id, page);
            ViewBag.Disc = discussions;
            return View(room);
        }

        [HttpGet]
        [Authorize]
        [ResponseCache(Duration = 1)]
        public IActionResult Create(long? id)
        {
            if (id == null)
                return NotFound();
            if (!_castleService.isCastleExist((long)id))
                return NotFound();
            ViewBag.Castle = _castleService.GetCastle((long)id);
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(string title, string text, long? id, IFormFile? file)
        {
            if (id == null)
                return NotFound();
            if(title == null)
            {
                ViewBag.Error = "Title field should be passed";
                return View();
            }
            if (text == null)
            {
                ViewBag.Error = "Text field should be passed";
                return View();
            }
            string? path = null;
            if (file != null) 
            {
                path = "/attachments/" + file.FileName;
                await file.CopyToAsync(new FileStream(_appEnvironment.WebRootPath+path, FileMode.Create));
            }
            _roomService.CreateRoom(text, title, HttpContext.User.Identity.Name, (long)id, path);
            return Redirect("/");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddDiscuss(long id, string text, IFormFile? file)
        {
            string? path = null;
            if(file != null)
            {
                path = "/attachments/" + file.FileName;
                await file.CopyToAsync(new FileStream(_appEnvironment.WebRootPath+path, FileMode.Create));
            }
            _discussionService.AddDiscussion(text, HttpContext.User.Identity.Name, id, path);
            return Redirect($"/Room/Detail/{id}");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddReply(long id, string text, long replyid, IFormFile? file)
        {
            string? path = null;
            if(file != null)
            {
                path = "/attachments/" + file.FileName;
                await file.CopyToAsync(new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create));
            }
            long discussid = _discussionService.AddReply(text, HttpContext.User.Identity.Name, id, replyid, path);

            string username = _discussionService.GetDiscussion(replyid).author.username;
            _notificationService.CreateNotification($"User @{HttpContext.User.Identity.Name} added reply to your discuss", username, $"/Room/Detail/{id}");
            return Redirect($"/Room/Detail/{id}");
        }
    }
}
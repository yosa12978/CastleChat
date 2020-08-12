using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CastleChat.Models;
using CastleChat.Services.Interfaces;

namespace CastleChat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICastleService _castleService;
        private readonly IRoomService _roomService;
        private readonly IUserService _userService;
        private readonly IDiscussionService _discussionService;
        public HomeController(ILogger<HomeController> logger,
            ICastleService castleService,
            IRoomService roomService,
            IUserService userService,
            IDiscussionService discussionService)
        {
            _logger = logger;
            _castleService = castleService;
            _roomService = roomService;
            _userService = userService;
            _discussionService = discussionService;
        }

        public IActionResult Index()
        {
            List<Castle> castles = _castleService.GetCastles();
            return View(castles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

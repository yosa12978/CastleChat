using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CastleChat.Models;
using CastleChat.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CastleChat.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUserService _userService;
        private readonly IRoomService _roomService;
        private readonly IDiscussionService _discussionService;
        private readonly ICastleService _castleService;
        private readonly IWebHostEnvironment _appEnvironment;
        public AccountController(ILogger<AccountController> logger,
                                IUserService userService,
                                IRoomService roomService,
                                IDiscussionService discussionService,
                                ICastleService castleService,
                                IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _userService = userService;
            _roomService = roomService;
            _discussionService = discussionService;
            _castleService = castleService;
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        public IActionResult Index(string? name)
        {
            string username = name ?? HttpContext.User.Identity.Name;
            if (!_userService.isUsernameExist(username))
                return NotFound();
            User user = _userService.GetUser(username);
            return View(user);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(IFormFile file)
        {
            if (file == null)
                return Redirect("/Account");
            string path = "/icons/" + file.FileName;
            await file.CopyToAsync(new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create));
            _userService.addIcon(path, HttpContext.User.Identity.Name);
            return Redirect("/Account");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                return Redirect("/");
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string username, string password)
        {
            if (username == null || password == null)
            {
                ViewBag.Error = "Invalid Cerdentials.";
                return View();
            }
            ClaimsPrincipal principal = _userService.Authenticate(username, password);
            if (principal == null)
            {
                ViewBag.Error = "Invalid Cerdentials.";
                return View();
            }
            await HttpContext.SignInAsync(principal);
            return Redirect("/");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Signup()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                return Redirect("/");
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Signup(string username, string password, string passwordC)
        {
            if (username == null || password == null)
            {
                ViewBag.Error = "Invalid Cerdentials.";
                return View();
            }
            if (_userService.isUsernameExist(username))
            {
                ViewBag.Error = "Username is already in use.";
                return View();
            }
            if (password != passwordC)
            {
                ViewBag.Error = "Passwords does not match.";
                return View();
            }
            _userService.Signup(username, password);
            return Redirect("/Account/Login");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Account/Login");
        }
    }
}
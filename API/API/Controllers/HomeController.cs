using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Models;
using Microsoft.AspNetCore.Identity;
using API.Data;

namespace API.Controllers
{
  public class HomeController : Controller
  {
    public readonly ApplicationDbContext _context;
    public readonly UserManager<AppUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
           var currentUser = await _userManager.GetUserAsync(User);
      ViewBag.CurrentUserName = currentUser.UserName;
      var mensagens = await _context.Messages.ToListAsync();
      return View();
        }

        public async Task<IActionResult> Create(Messagem mensagem)

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

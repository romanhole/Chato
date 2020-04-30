using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
     // var mensagens = await _context.Mensagens.ToListAsync();
            return View();
        }

    public async Task<IActionResult> Create(Mensagem mensagem)
    {
      if(ModelState.IsValid)
      {
        mensagem.NomeUsuario = User.Identity.Name;
        var remetente = await _userManager.GetUserAsync(User);
        mensagem.UserID = remetente.Id;
    //    await _context.mensagens.AddSync(mensagem);
        await _context.SaveChangesAsync();
        return Ok();
      }
      return Error();
    }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

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

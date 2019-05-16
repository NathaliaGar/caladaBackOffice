using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalveMariaBackoffice.Data;
using SalveMariaBackoffice.Models;

namespace SalveMariaBackoffice.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;


        public HomeController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {

            var retorno = _context.Alertas.OrderByDescending(x=>x.Id).ToList();

            return View(retorno);
        }


        public IActionResult Sobre()
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

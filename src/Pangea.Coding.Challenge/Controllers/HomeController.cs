using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pangea.Coding.Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace Pangea.Coding.Challenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly PangeaContext _context;

        public HomeController(PangeaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<GitHubRepository> repositories =
                _context.Repositories
                    .Include(e => e.owner)
                    .ToList();

            ViewData["Repositories"] = repositories;

            return View();
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

        public IActionResult Error()
        {
            return View();
        }
    }
}

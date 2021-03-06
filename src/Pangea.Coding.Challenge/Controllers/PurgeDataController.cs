﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pangea.Coding.Challenge.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Pangea.Coding.Challenge.Controllers
{
    public class PurgeDataController : Controller
    {
        private readonly PangeaContext _context;

        public PurgeDataController(PangeaContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            foreach(GitHubRepository repo in _context.Repositories.ToList())
            {
                _context.Remove(repo);
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Home", new { });
        }
    }
}

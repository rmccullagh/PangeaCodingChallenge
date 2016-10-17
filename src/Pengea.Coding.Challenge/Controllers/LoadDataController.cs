using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pangea.Coding.Challenge.Models;
using Pengea.Coding.Challenge.Libraries;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Pangea.Coding.Challenge.Controllers
{
    public class LoadDataController : Controller
    {
        private readonly PangeaContext _context;
        private readonly IGithubClient _githubClient;

        public LoadDataController(PangeaContext context, IGithubClient githubClient)
        {
            _context = context;
            _githubClient = githubClient;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            if (_context.Repositories.ToList().Count == 0)
            {
                // populate the data from the GitHub API
                foreach(GitHubRepository repo in await _githubClient.FetchRepositories("orgs/gopangea/repos"))
                {
                    _context.Repositories.Add(repo);
                }

                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home", new { });
        }
    }
}

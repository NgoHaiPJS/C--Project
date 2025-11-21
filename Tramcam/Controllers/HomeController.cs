using Microsoft.AspNetCore.Mvc;
using Tramcam.Data;
using Tramcam.Models;

namespace Tramcam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var featuredArticles = new List<Article>();
            var supportGroups = new List<SupportGroup>();

            try
            {
                featuredArticles = _context.Articles?
                    .Where(a => a.IsPublished)
                    .OrderByDescending(a => a.CreatedDate)
                    .Take(3)
                    .ToList() ?? new List<Article>();

                supportGroups = _context.SupportGroups?
                    .Where(sg => sg.IsActive)
                    .Take(4)
                    .ToList() ?? new List<SupportGroup>();
            }
            catch (Exception ex)
            {
                // Log the exception if you have logging configured
                featuredArticles = new List<Article>();
                supportGroups = new List<SupportGroup>();
            }

            ViewBag.FeaturedArticles = featuredArticles;
            ViewBag.SupportGroups = supportGroups;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Resources()
        {
            var resources = _context.Resources
                .Where(r => r.IsApproved)
                .OrderBy(r => r.Title)
                .ToList();

            return View(resources);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
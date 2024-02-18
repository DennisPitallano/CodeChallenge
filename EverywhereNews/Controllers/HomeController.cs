using EverywhereNews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EverywhereNews.Services;

namespace EverywhereNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsClient _newsClient;
        public string Country { get; set; } = "us";
        public string Category { get; set; } = "all";
        public string Language { get; set; } = "all";
        public string Search { get; set; } = string.Empty;
        public string Source { get; set; } = "top";
        public HomeController(ILogger<HomeController> logger, INewsClient newsClient)
        {
            _logger = logger;
            _newsClient = newsClient;
        }

        public async Task<IActionResult> Index(string? source, string? country,string?category, string?language, string? search)
        {
            Search = search ?? string.Empty;
            Country = country ?? "us";
            Category = category ?? "all";
            Language = language ?? "all";
            Source = source??"top";
            ViewBag.Search = Search;
            ViewBag.SelectedCountry = Country;
            ViewBag.SelectedCategory = Category;
            ViewBag.SelectedLanguage = Language;
            ViewBag.Source = Source;
            ViewBag.NewsTitle = "News Everywhere";
            IEnumerable<Article>? articles;
            if (Source =="top")
            {
                articles = await _newsClient.GetTopHeadlines(Country,Search,Category);
            }
            else
            {
                articles = await _newsClient.GetEverything(Search,Language);
            }

            return View(articles);
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

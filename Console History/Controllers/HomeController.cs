using Console_History.Data;
using Console_History.Models;
using Console_History.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Console_History.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GamingDbContext _context;

        public HomeController(ILogger<HomeController> logger, GamingDbContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new HomePageVM();

            viewModel.HomePage = _context.HomePages.ToList();
            viewModel.SliderGames = _context.SliderGames.ToList();

            return View(viewModel);
        }

        public IActionResult Platform(int id)
        {
            var platform = _context.Platforms
                .Include(p => p.platformConsoles)
                .ThenInclude(pc => pc.Console)
                .FirstOrDefault(p => p.ID == id);

            if (platform == null)
            {
                return NotFound();
            }

            return View(platform);
        }

        public IActionResult GameAwards()
        {
            var viewModel = new GameAwardsVM();

            viewModel.GameAwards = _context.GameAwards.ToList();
            viewModel.GameAwardsSlider = _context.GameAwardsSliders.ToList();

            return View(viewModel);
        }

        public IActionResult Search(string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
            {
                ViewBag.Message = "Por favor, insira um termo de busca.";
                return View(); // Retorna uma View com um aviso.
            }

            // Normalize the search string
            searchString = searchString.Trim().ToLower();

            // Verificar se a busca corresponde a uma das plataformas
            var platform = _context.Platforms.FirstOrDefault(p => p.Name.ToLower() == searchString);
            if (platform != null)
            {
                return RedirectToAction("Platform", new { id = platform.ID });
            }

            // Verificar se a busca é pela página "The Game Awards"
            if (searchString.Contains("game awards") || searchString.Contains("awards"))
            {
                return RedirectToAction("GameAwards");
            }

            // Se nenhuma correspondência for encontrada
            ViewBag.Message = "Nenhum resultado encontrado para sua busca.";
            return View(); // Retorna uma View de resultados vazios.
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

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestsAppCoreMVC.Data;
using TestsAppCoreMVC.Models;

namespace TestsAppCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _ctx;

        public HomeController(ILogger<HomeController> logger, AppDbContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
           var tests = await _ctx.Tests
                .Include(p => p.Questions)
                .Take(3)
                .ToListAsync();
            return View(tests);
        }

        [Route("[controller]/[action]/{id}")]
        public async Task<JsonResult> GetTestById(int id)
        {
            var test = await _ctx.Tests.FirstOrDefaultAsync(p => p.Id == id);
            if (test == null) return Json(new { error = 404 });
            return Json(test);
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

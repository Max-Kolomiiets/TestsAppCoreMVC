using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TestsAppCoreMVC.Data;

namespace TestsAppCoreMVC.Controllers
{
    public class TestController : Controller
    {
        private readonly AppDbContext _ctx;
        public TestController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        [Route("[controller]/{id}")]
        public async Task<IActionResult> Index(int? id)
        {
            var test = await _ctx.Tests
                .Include(p => p.Questions)
                .ThenInclude(p => p.Answers)
                .FirstOrDefaultAsync(p => p.Id == id);
                
            return View(test);
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> Index(int? testId)
        {
            var test = await _ctx.Tests.FindAsync(testId);

            return View(test);
        }


    }
}

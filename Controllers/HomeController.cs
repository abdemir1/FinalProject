using CET322Final.Data;
using CET322Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace CET322Final.Controllers
{
    public class HomeController : Controller
        

    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var query= dbContext.Recipes.Include(t => t.Category).Where(t => true).OrderByDescending(t => t.CreatedDate);

            List<Recipe> result = await query.ToListAsync();
            return View( result);
            
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

using System;
using Microsoft.AspNetCore.Mvc;
using Forever_Home_Finder.Models;

namespace Forever_Home_Finder.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Pet> data { get; set; }
        public HomeController(ForeverContext ctx) => data = new Repository<Pet>(ctx);

        public ViewResult Index()
        {
            var random = data.Get(new QueryOptions<Pet>
            {
                OrderBy = b => Guid.NewGuid()
            });

            return View(random);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Forever_Home_Finder.Models;

namespace Forever_Home_Finder.Controllers
{
    public class PetController : Controller
    {
        private PetUnitOfWork data { get; set; }
        public PetController(ForeverContext ctx) => data = new PetUnitOfWork(ctx);

        public RedirectToActionResult Index() => RedirectToAction("List");

        public ViewResult List(PetsGridDTO values)
        {
            var builder = new PetsGridBuilder(HttpContext.Session, values,
                defaultSortField: nameof(Pet.PetName));

            var options = new PetQueryOptions
            {
                Include = "PetType",
                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };
            options.SortFilter(builder);

            var vm = new PetListViewModel
            {
                Pets = data.Pets.List(options),
                PetType = data.PetTypes.List(new QueryOptions<PetType>
                {
                    OrderBy = a => a.PetTypeName
                }),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Pets.Count)
            };

            return View(vm);
        }

        public ViewResult Details(int id)
        {
            var pet = data.Pets.Get(new QueryOptions<Pet>
            {
                Include = "PetType",
                Where = p => p.PetTypeId == id
            });
            return View(pet);
        }

        [HttpPost]
        public RedirectToActionResult Filter(string[] filter, bool clear = false)
        {
            var builder = new PetsGridBuilder(HttpContext.Session);

            if (clear)
            {
                builder.ClearFilterSegments();
            }
            else
            {
                var petType = data.PetTypes.Get(filter[0].ToInt());
                builder.LoadFilterSegments(filter, petType);
            }

            builder.SaveRouteSegments();
            return RedirectToAction("List", builder.CurrentRoute);
        }
    }
}

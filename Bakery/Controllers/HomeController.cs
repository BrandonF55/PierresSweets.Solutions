using Microsoft.AspNetCore.Mvc;
using Bakery.Models;


namespace Bakery.Controllers
{
    public class HomeController : Controller
    {

    private readonly BakeryContext _db;

    public HomeController(BakeryContext db)
    {
      _db = db;
    }
     [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Treat = new List<Treat>(_db.Treats);
        ViewBag.Flavors = new List<Flavor>(_db.Flavors);
        return View(ViewBag.Treat);
      }
    }
}
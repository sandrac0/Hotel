using Hotel.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class Hoteis : Controller
    {
        private readonly ApplicationDbContext _db;

        public Hoteis(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()

        {
            var X=_db.Quartos.ToList();
            return View(X);
        }
    }
}

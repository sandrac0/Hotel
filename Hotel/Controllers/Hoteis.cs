using Hotel.Domain.Entities;
using Hotel.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Quartos id)
        {
            if (ModelState.IsValid)
            {
                _db.Quartos.Add(id);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(id);
        }
        public IActionResult Update(int quartosId)
        {
            Quartos? obj = _db.Quartos.FirstOrDefault(x=>x.Id==quartosId);
            if (obj==null)
            {
            return RedirectToAction("Error","Home");
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Quartos model)
        {
            if (ModelState.IsValid)
            {
                _db.Quartos.Update(model);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public IActionResult Delete(int model)
        {
            Quartos? obj = _db.Quartos.FirstOrDefault(_ => _.Id == model);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Quartos obj)
        {
            Quartos? objFromDb = _db.Quartos.FirstOrDefault(_ => _.Id == obj.Id);
            if (objFromDb is not null)
            {
                _db.Quartos.Remove(objFromDb);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

    }
}

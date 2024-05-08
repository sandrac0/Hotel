using Hotel.Infrastructure.Data;
using Hotel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hotel.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var clientenumber = _db.Clientes.Include(x => x.Quarto).ToList();
            return View(clientenumber);
        }

        public IActionResult Create()
        {
            var hotelvm = new hotelvm()
            {
                quartosList = _db.Quartos.ToList().Select(x => new SelectListItem
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                })
            };
            return View(hotelvm);
        }
    }
}

using Hotel.Application.Common.Interface;
using Hotel.Domain.Entities;
using Hotel.Infrastructure.Data;
using Hotel.Infrastructure.Repository;
using Hotel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hotel.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IUnityOfWork _unityOfWork;

        public ClienteController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public IActionResult Index()
        {
            var clientenumber = _unityOfWork.Cliente.GetAll(includeProperties: "Quartos");    
            return View(clientenumber);
        }

        public IActionResult Create()
        {
            var hotelvm = new hotelvm()
            {
                quartosList = _unityOfWork.Quartos.GetAll().Select(x => new SelectListItem
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                })
            };
            return View(hotelvm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(hotelvm obj)
        {
            if (ModelState.IsValid)
            {
                _unityOfWork.Cliente.Add(obj.clientes);
                _unityOfWork.Save();
                return RedirectToAction("Index");
            }
            obj.quartosList = _unityOfWork.Quartos.GetAll().Select(u => new SelectListItem
            {
                Text = u.Description,
                Value = u.Id.ToString()
            });
            return View(obj);
            
        }
        public IActionResult Update(int quartosId)
        {
            hotelvm hotelvm = new hotelvm
            {
                quartosList = _unityOfWork.Quartos.GetAll().Select(x => new SelectListItem
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                }),
                clientes = _unityOfWork.Cliente.Get(_ => _.Id == quartosId)
            };
            return View(hotelvm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Cliente obj)
        {
            if (ModelState.IsValid)
            {
                _unityOfWork.Cliente.Update(obj);
                _unityOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int quartosId)
        {

            hotelvm hotelvm = new hotelvm
            {
                quartosList = _unityOfWork.Quartos.GetAll().Select(x => new SelectListItem
                {
                    Text = x.Description,
                    Value = x.Id.ToString()
                }),
                clientes = _unityOfWork.Cliente.Get(_ => _.Id == quartosId)
            };
            if (hotelvm.clientes is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(hotelvm);
        }
        [HttpPost]
        public IActionResult Delete(hotelvm hotelvm)
        {
            Cliente? objFromDb = _unityOfWork.Cliente.Get(_=>_.Id== hotelvm.clientes.Id);
            if (objFromDb is not null)
            {
                _unityOfWork.Cliente.Remove(objFromDb);
                _unityOfWork.Save();
                return RedirectToAction("Index");
            } return View(hotelvm);
        }

    }
    

}

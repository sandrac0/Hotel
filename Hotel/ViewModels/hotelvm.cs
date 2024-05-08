using Hotel.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hotel.ViewModels
{
    public class hotelvm
    {
        public Cliente clientes { get; set; }
        public IEnumerable <SelectListItem > quartosList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Quartos
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
            
    }
}

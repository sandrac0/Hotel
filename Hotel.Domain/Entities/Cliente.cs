using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Quartos Quarto { get; set; } = null!;
        [ValidateNever]

        [ForeignKey("Quartos")]
        public int QuartosId  { get; set; }
    }
}

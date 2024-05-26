using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Interface
{
    public interface IHotel: IRepository<Quartos>
    {
        void Add(Quartos entity);
        void Update(Quartos entity);
    }
}

using Hotel.Application.Common.Interface;
using Hotel.Domain.Entities;
using Hotel.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Repository
{
    public class QuartosRepository : Repository<Quartos>, IHotel
    {
        private readonly ApplicationDbContext _db;
        public QuartosRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(Quartos entity)
        {
            _db.Update(entity); 
        }
    }
}

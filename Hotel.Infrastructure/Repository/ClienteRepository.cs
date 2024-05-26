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
    public class ClienteRepository: Repository<Cliente>, ICliente
    {
        private readonly ApplicationDbContext _db;
        public ClienteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Cliente entity)
        {
            _db.Update(entity);
        }
    }
  }


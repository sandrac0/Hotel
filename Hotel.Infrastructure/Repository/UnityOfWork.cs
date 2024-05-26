using Hotel.Application.Common.Interface;
using Hotel.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICliente Cliente {  get; private set; }

        public IHotel Quartos {  get; private set; }
        public UnityOfWork(ApplicationDbContext db)
        {
            _db = db;
            Cliente = new ClienteRepository(db);
            Quartos = new QuartosRepository(db);
        }
        public void Save() {
        _db.SaveChanges();
        }
    }
}

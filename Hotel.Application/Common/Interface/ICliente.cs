using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Interface
{
    public interface ICliente: IRepository<Cliente>
    {
        void Update(Cliente entity);


    }
}

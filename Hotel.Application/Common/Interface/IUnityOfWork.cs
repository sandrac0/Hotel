using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Common.Interface
{
    public interface IUnityOfWork
    {
        ICliente Cliente { get; }   
        IHotel Quartos { get; }
        void Save();
    }
}

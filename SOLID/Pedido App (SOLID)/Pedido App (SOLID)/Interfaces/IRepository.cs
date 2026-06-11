using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_App__SOLID_.Interfaces
{
    public interface IRepository<T>
    {
        void Save(T entity);
    }
}

using Pedido_App__SOLID_.Interfaces;
using Pedido_App__SOLID_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_App__SOLID_.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        public void Save(Order order)
        {
            Console.WriteLine("Pedido salvo no banco.");
        }
    }
}

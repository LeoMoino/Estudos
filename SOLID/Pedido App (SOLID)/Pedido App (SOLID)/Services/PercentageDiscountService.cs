using Pedido_App__SOLID_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_App__SOLID_.Services
{
    public class PercentageDiscountService : IDiscountService
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount * 0.90m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_App__SOLID_.Interfaces
{
    public interface IDiscountService
    {
        decimal ApplyDiscount(decimal amount);
    }
}

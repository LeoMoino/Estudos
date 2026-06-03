using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    public class CartaoCreditoPagamento : Payment
    {
        public void PayCreditCard()
        {
            //var payment = new Payment(); abstract class não pode ser instanciada
            Pay();
        }   
    }
}

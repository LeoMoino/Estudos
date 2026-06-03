using System;

namespace Abstração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CartaoCreditoPagamento pagamento = new CartaoCreditoPagamento();
            
            pagamento.ExpirationDate = DateTime.Now.AddMonths(1);

            pagamento.PayCreditCard();

            Console.WriteLine($"Data de expiração: {pagamento.ExpirationDate}");

            Console.ReadKey();
        }
    }
}
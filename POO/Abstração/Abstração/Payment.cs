using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    public abstract class Payment
    {
        public DateTime ExpirationDate { get; set; }

        public void Pay()
        {
            if (CheckAccountBankMoney())
            {
                // Lógica de pagamento
                Console.WriteLine("Pagamento realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Não foi possivel realizar o pagamento, saldo insuficiente.");
            }

        }
        private bool CheckAccountBankMoney()
        {
            // Simulação de verificação de dinheiro na conta bancária
            return true;
        }

    }
}

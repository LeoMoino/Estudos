namespace Encapsulamento
{
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
                Saldo -= valor;
        }
    }
}
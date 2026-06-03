using Encapsulamento;

ContaBancaria conta = new ContaBancaria();

bool executando = true;

while (executando)
{
    Console.Clear();

    Console.WriteLine("=== CONTA BANCÁRIA ===");
    Console.WriteLine($"Saldo atual: R$ {conta.Saldo}");
    Console.WriteLine();
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Sair");
    Console.WriteLine();

    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite o valor para depósito: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
            {
                if (valorDeposito > 0)
                {
                    conta.Depositar(valorDeposito);
                    Console.WriteLine("Depósito realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("O valor do deposito precisa ser maior que 0");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
            break;

        case "2":
            Console.Write("Digite o valor para saque: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
            {
                if (valorSaque <= conta.Saldo)
                {
                    conta.Sacar(valorSaque);
                    Console.WriteLine("Operação realizada.");
                }
                else
                {
                    Console.WriteLine("Saque não realizado, saldo insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
            break;

        case "3":
            executando = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (executando)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
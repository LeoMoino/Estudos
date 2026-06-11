# SOLID em C#

Projeto criado com o objetivo de estudar e praticar os princípios SOLID utilizando C#.

O sistema simula um processamento de pedidos onde é possível aplicar descontos, salvar pedidos e enviar notificações.

## Estrutura do Projeto

```
PedidoApp
│
├── Models
│   ├── Product.cs
│   ├── Order.cs
│
├── Interfaces
│   ├── IDiscountService.cs
│   ├── INotificationService.cs
│   ├── IRepository.cs
│
├── Services
│   ├── OrderProcessor.cs
│   ├── PercentageDiscountService.cs
│   ├── EmailNotificationService.cs
│   ├── SmsNotificationService.cs
│
├── Repositories
│   ├── OrderRepository.cs
│
└── Program.cs
```

## Fluxo da Aplicação

```
Program.cs
    │
    ▼
OrderProcessor
    │
    ├── IDiscountService
    │       ▼
    │   PercentageDiscountService
    │
    ├── IRepository<Order>
    │       ▼
    │   OrderRepository
    │
    └── INotificationService
            ▼
    EmailNotificationService
    ou
    SmsNotificationService
```

## Classes

### Product.cs

Representa um produto.

Responsabilidades:

- Armazenar nome do produto.
- Armazenar preço do produto.

---

### Order.cs

Representa um pedido.

Responsabilidades:

- Adicionar produtos.
- Calcular valor total do pedido.

Relacionamento:

- Composição com Product.

```
private readonly List<Product> _products;
```

---

### IDiscountService.cs

Interface responsável por definir o contrato para aplicação de descontos.

```
public interface IDiscountService
{
    decimal ApplyDiscount(decimal amount);
}
```

---

### PercentageDiscountService.cs

Implementação de desconto percentual.

```
public class PercentageDiscountService : IDiscountService
```

Responsabilidade:

- Aplicar desconto ao valor informado.

---

### INotificationService.cs

Contrato para envio de notificações.

```
public interface INotificationService
{
    void Send(string message);
}
```

---

### EmailNotificationService.cs

Implementação para envio de e-mail.

```
public class EmailNotificationService : INotificationService
```

---

### SmsNotificationService.cs

Implementação para envio de SMS.

```
public class SmsNotificationService : INotificationService
```

---

### IRepository.cs

Contrato genérico para persistência de dados.

```
public interface IRepository<T>
{
    void Save(T entity);
}
```

---

### OrderRepository.cs

Responsável por salvar pedidos.

```
public class OrderRepository : IRepository<Order>
```

---

### OrderProcessor.cs

Classe responsável por processar um pedido.

Responsabilidades:

- Obter valor total.
- Aplicar desconto.
- Salvar pedido.
- Enviar notificação.

Dependências:

```
IDiscountService
INotificationService
IRepository<Order>
```

---

### Program.cs

Ponto de entrada da aplicação.

Responsável por:

- Criar objetos.
- Configurar dependências.
- Executar processamento do pedido.

## Aplicação dos Princípios SOLID

### S - Single Responsibility Principle

Uma classe deve possuir apenas uma responsabilidade.

Exemplos:

| Classe | Responsabilidade |
|----------|----------|
| Product | Representar produto |
| Order | Gerenciar produtos do pedido |
| OrderRepository | Salvar pedido |
| EmailNotificationService | Enviar e-mail |
| PercentageDiscountService | Aplicar desconto |

---

### O - Open Closed Principle

Classes devem estar abertas para extensão e fechadas para modificação.

Exemplo:

É possível criar novos tipos de desconto sem alterar o código existente.

```
public class TwentyPercentDiscountService : IDiscountService
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * 0.80m;
    }
}
```

---

### L - Liskov Substitution Principle

Uma implementação deve poder substituir sua abstração sem quebrar o sistema.

Exemplo:

```
INotificationService service =
    new EmailNotificationService();
```

Pode ser substituído por:

```
INotificationService service =
    new SmsNotificationService();
```

Sem necessidade de alterar o restante da aplicação.

---

### I - Interface Segregation Principle

Interfaces devem ser pequenas e específicas.

Bom exemplo:

```
public interface INotificationService
{
    void Send(string message);
}
```

Evita interfaces com múltiplas responsabilidades.

---

### D - Dependency Inversion Principle

Módulos de alto nível não devem depender de implementações concretas.

OrderProcessor depende de abstrações:

```
private readonly IDiscountService _discountService;
private readonly INotificationService _notificationService;
private readonly IRepository<Order> _repository;
```

Dessa forma o processamento não depende diretamente de classes concretas.

## Conceitos de POO Utilizados

### Associação

OrderProcessor utiliza serviços externos.

```
OrderProcessor -> INotificationService
```

---

### Agregação

OrderProcessor recebe dependências pelo construtor.

```
public OrderProcessor(
    IDiscountService discountService,
    INotificationService notificationService,
    IRepository<Order> repository)
```

As dependências continuam existindo mesmo que o OrderProcessor seja destruído.

---

### Composição

Order possui uma coleção de produtos.

```
private readonly List<Product> _products;
```

Os produtos pertencem ao pedido.

## Objetivo

Este projeto foi desenvolvido para praticar:

- Programação Orientada a Objetos
- SOLID
- Interfaces
- Injeção de Dependência
- Composição
- Agregação
- Associação
- Boas práticas de desenvolvimento em C#
using Pedido_App__SOLID_.Models;
using Pedido_App__SOLID_.Repositories;
using Pedido_App__SOLID_.Services;

var order = new Order();

order.AddProduct(new Product("Mouse", 100));
order.AddProduct(new Product("Teclado", 200));

var discountService =
    new PercentageDiscountService();

var notificationService =
    new EmailNotificationService();

var repository =
    new OrderRepository();

var processor =
    new OrderProcessor(
        discountService,
        notificationService,
        repository);

processor.Process(order);
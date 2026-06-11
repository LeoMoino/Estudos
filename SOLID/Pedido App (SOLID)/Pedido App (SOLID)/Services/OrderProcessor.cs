using Pedido_App__SOLID_.Interfaces;
using Pedido_App__SOLID_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_App__SOLID_.Services
{
    public class OrderProcessor
    {
        private readonly IDiscountService _discountService;
        private readonly INotificationService _notificationService;
        private readonly IRepository<Order> _repository;

        public OrderProcessor(
            IDiscountService discountService,
            INotificationService notificationService,
            IRepository<Order> repository)
        {
            _discountService = discountService;
            _notificationService = notificationService;
            _repository = repository;
        }

        public void Process(Order order)
        {
            decimal total = order.Total();

            decimal finalValue =
                _discountService.ApplyDiscount(total);

            _repository.Save(order);

            _notificationService.Send(
                $"Pedido processado. Total: {finalValue:C}"
            );
        }
    }
}

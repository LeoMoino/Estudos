using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_App__SOLID_.Models
{
    public class Order
    {
        private readonly List<Product> _products;

        public IReadOnlyCollection<Product> Products => _products;

        public Order()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal Total()
        {
            return _products.Sum(p => p.Price);
        }
    }
}

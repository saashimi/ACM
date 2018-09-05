using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 5, 1, 8, 30, 52, new TimeSpan(1, 0, 0));
            }
            return order;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        public bool Save()
        {
            return true;
        }
    }
}

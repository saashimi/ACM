﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Save()
        {
            return true;
        }

        public Boolean Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}

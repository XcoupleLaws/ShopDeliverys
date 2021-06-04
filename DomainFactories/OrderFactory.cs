using System;
using System.Collections.Generic;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Domain.WarehouseDomain;

namespace DomainFactories
{
    public class OrderFactory
    {
        public OrderModel CreateOrder(WarehouseModel warehouse,
            List<OrderItemModel> goods)
        {
            var order = new OrderModel
            {
                OrderItems = goods,
                Warehouse = warehouse,
                TimeOfCreation = DateTime.Now
            };
            return order;
        }
    }
}
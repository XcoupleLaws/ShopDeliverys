using System.Collections.Generic;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Domain.WarehouseDomain;

namespace Services.Abstractions
{
    public interface IOrderService
    {
        OrderModel MakeOrder();
        void ProcessOrder(OrderModel order);
        void Add(OrderModel order);
        public List<OrderModel> GetAll();
    }
}
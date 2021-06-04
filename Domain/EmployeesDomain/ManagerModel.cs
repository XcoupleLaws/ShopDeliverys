using System;
using System.Linq;
using Domain.OrderDomain;
using Types;

namespace Domain.EmployeesDomain
{
    public class ManagerModel : EmployeeModel
    {
        public override Speciality Speciality => Speciality.Manager;

        public TimeSpan CalculateOrderProcessTime(OrderModel order)
        {
            return order.OrderItems
                        .Select(goods => goods.Goods.ProcessTime)
                        .Aggregate((goodsProcessTime1,goodsProcessTime2 ) =>
	                        goodsProcessTime1 + goodsProcessTime2);
        }

        public double CalculateOrderCost(OrderModel order)
        {
            return order.OrderItems
                .Select(goods =>
	                goods.Goods.Price * goods.Quantity)
                .Aggregate((goodsPrice1, goodsPrice2) => 
	                goodsPrice1 + goodsPrice2);
        }

        public override void ProcessOrder(OrderModel order)
        {
            order.ManagerId = Id;

            order.TotalCost = CalculateOrderCost(order);
            
            LoadedHours += CalculateOrderProcessTime(order);;
            
            order.EstimateProcessTime = LoadedHours;
        }

    }
}
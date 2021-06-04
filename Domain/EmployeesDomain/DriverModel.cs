using System;
using System.Net.Sockets;
using Domain.OrderDomain;
using Types;

namespace Domain.EmployeesDomain
{
    public class DriverModel : EmployeeModel
    {
        public int AverageSpeed = 70 + new Random().Next(-10,10);

        public override Speciality Speciality
        {
            get => Speciality.Driver;
        }

        public TimeSpan CalculateDeliveryTime(OrderModel order)
        {
            double deliveryTime = (double)(order.RelativeDistance*2) / AverageSpeed;

            var deliveryHours = (int)Math.Truncate(deliveryTime);
            
            int deliveryMinutes = (int)((deliveryTime - deliveryHours) * 60);

            return new TimeSpan(deliveryHours, deliveryMinutes, 0);
        }

        public override void ProcessOrder(OrderModel order)
        {
            order.DriverId = Id;

            LoadedHours += CalculateDeliveryTime(order);
            
            order.EstimateProcessTime = LoadedHours;

        }

    }
}
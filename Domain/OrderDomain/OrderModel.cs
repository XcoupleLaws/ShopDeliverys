using System;
using System.Collections.Generic;
using Domain.EmployeesDomain;
using Domain.GoodsDomain;
using Domain.WarehouseDomain;

namespace Domain.OrderDomain
{
    public class OrderModel
    {
        public int Id { get; set; }
        
        public WarehouseModel Warehouse { get; set; }
        

        public int ManagerId { get; set; }         
        public int DriverId { get; set; }

        public int RelativeDistance => Warehouse.Distance;				
        public DateTime TimeOfCreation { get; set; }
        public TimeSpan EstimateProcessTime { get; set; }
        
        public double TotalCost { get; set; }

        public bool Completed { get; set; } = false;

        public List<OrderItemModel> OrderItems{ get; set; }
        
    }
}
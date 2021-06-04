using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class OrderEntity : IEntity
    {
        public int Id { get; set; }

        public int WarehouseId { get; set; }
        public virtual WarehouseEntity Warehouse { get; set; }
        public int ManagerId { get; set; }

        public int DriverId { get; set; }

        public double TotalCost { get; set; }
        
        public DateTime TimeOfCreation { get; set; }
        public Int64 EstimateProcessTimeTicks { get; set; }

        [NotMapped]
        public TimeSpan EstimateProcessTime
        {
	        get => TimeSpan.FromTicks(EstimateProcessTimeTicks);
	        set => EstimateProcessTimeTicks = value.Ticks;
        }
        
        public bool Completed { get; set; }

        public virtual Collection<GoodsEntity> Goods { get; set; }	
        public virtual Collection<OrderItemEntity> OrderItems { get; set; }
    }
}
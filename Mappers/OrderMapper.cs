using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Domain.EmployeesDomain;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Entities;

namespace Mappers
{
    public class OrderMapper
    {
	    private  GoodsMapper _goodsMapper;
	    private  EmployeeMapper _employeeMapper;
	    private  WarehouseMapper _warehouseMapper;
	    
	    public OrderEntity ToEntity(OrderModel order)
	    {
		    return new()
		    {
			    Id = order.Id,
			    WarehouseId = order.Warehouse.Id,
			    ManagerId = order.ManagerId,
			    DriverId = order.DriverId,
			    Completed = order.Completed,
			    EstimateProcessTime = order.EstimateProcessTime,
			    TimeOfCreation = order.TimeOfCreation,
			    TotalCost = order.TotalCost
		    };
	    }

	    public OrderModel ToModel(OrderEntity order)
        {
	        _goodsMapper = new GoodsMapper();
	        _warehouseMapper = new WarehouseMapper();
	        _employeeMapper = new EmployeeMapper();
	        return new OrderModel
	        {
                Id = order.Id,
                Warehouse = _warehouseMapper.ToModel(order.Warehouse),
                ManagerId = order.ManagerId,
                DriverId = order.DriverId,
                Completed = order.Completed,
                EstimateProcessTime = order.EstimateProcessTime,
                TimeOfCreation = order.TimeOfCreation,
                TotalCost = order.TotalCost,
                OrderItems = order.OrderItems.Select(entity => 
	                new OrderItemModel
	                {
		                Id = entity.Id,
		                Goods = _goodsMapper.ToModel(entity.Goods),
		                Quantity = entity.Quantity
	                })
	                .ToList()
	        };
        }
    }
}
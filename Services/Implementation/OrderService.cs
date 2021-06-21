using System;
using System.Collections.Generic;
using System.Linq;
using DAL.UnitOfWork;
using Domain.EmployeesDomain;
using Domain.OrderDomain;
using Entities;
using Mappers;
using Services.Abstractions;
using Services.ChainHandlers;
using Services.ResponsibilityChainHandlers;
using Types;

namespace Services.Implementation
{
    public class OrderService : IOrderService
    {
	    private readonly IUnitOfWork _unitOfWork;
	    
	    private readonly EmployeeMapper _employeeMapper;
	    private readonly OrderMapper    _orderMapper;

	    private readonly IStaffService _staffService;
	    
        public OrderService( IUnitOfWork context, OrderMapper orderMapper,EmployeeMapper employeeMapper, IStaffService staffService)
        {
            _unitOfWork = context;
            
            _employeeMapper = employeeMapper;
            _orderMapper    = orderMapper;
            
            _staffService = staffService;
        }

        public void ProcessOrder(OrderModel order)
        {

	        ChainNodeHandler chainNodeHandler;

	        EmployeeModel leastBusyManager = _staffService.GetLeastBusyEmployee(Speciality.Manager);
	        chainNodeHandler = new EmployeeNodeHandler(leastBusyManager);

	        EmployeeModel leastBusyDriver = _staffService.GetLeastBusyEmployee(Speciality.Driver);
	        chainNodeHandler.SetNextHandler(new EmployeeNodeHandler(leastBusyDriver));

	        chainNodeHandler.ProcessOrder(order);

	        Add(order);

	        _staffService.Update(leastBusyDriver);
	        _staffService.Update(leastBusyManager);
        }

        public OrderModel MakeOrder()
        {
            OrderModel order = new OrderModel
            {
	            OrderItems = new List<OrderItemModel>(),
	            TimeOfCreation = DateTime.Now,
	            Completed = false
            };
            return order;
        }
        public void Add(OrderModel order)
        {
	        _unitOfWork.Orders.Add(_orderMapper.ToEntity(order));
	        
	        order.OrderItems.ForEach(goods => 
	             _unitOfWork.OrderItems.Add(new OrderItemEntity 
	             {
		             GoodsId = goods.Goods.Id,
		             Quantity = goods.Quantity,
		             OrderId = _unitOfWork.Orders.GetAll().Last().Id
	             }));
             _unitOfWork.CommitChanges();
        }

        public List<OrderModel> GetAll() =>
	        _unitOfWork.Orders.GetAll()
		        .Select(order => _orderMapper.ToModel(order))
		        .ToList();

        public void Delete(OrderModel order)
        {
	        var orderEntity = _orderMapper.ToEntity(order);
	        var relatedEmployees  = _unitOfWork.Orders
			        .GetRelatedEmployees(orderEntity)
			        .Select<EmployeeEntity, EmployeeModel>(employeeEntity =>
			        ((employeeEntity.EmployeeSpecialityId == 1)
				        ? _employeeMapper.ToModel(employeeEntity) as DriverModel
				        : _employeeMapper.ToModel(employeeEntity) as ManagerModel)
			        !)
			        .ToList();
	        
	        foreach (var employeeModel in relatedEmployees)
	        {
		        if ((employeeModel as ManagerModel) == null)
			        employeeModel.LoadedHours -= ((employeeModel as DriverModel)!).CalculateDeliveryTime(order);
		        else 
			        employeeModel.LoadedHours -= ((employeeModel as ManagerModel)!).CalculateOrderProcessTime(order);
	        }
	        
	        relatedEmployees.Select(employeeModel => _employeeMapper
			        .ToEntity(employeeModel))
		        .ToList()
		        .ForEach(relatedEmployee => _unitOfWork.Employees.Update(relatedEmployee));
	        _unitOfWork.Orders.Delete(orderEntity);
	        _unitOfWork.CommitChanges();
        }
    }
}
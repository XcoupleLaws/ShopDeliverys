using System;
using System.Linq;
using Domain.EmployeesDomain;
using DomainFactories;
using Entities;

namespace Mappers
{
    public class EmployeeMapper
    {
	    private  OrderMapper _orderMapper;

	    public EmployeeEntity ToEntity(EmployeeModel employee) => new()
            {
                Id = employee.Id,
                Age = employee.Age,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                EmployeeSpecialityId = employee.SpecialityId,
                LoadedHours = employee.LoadedHours
            };

        public EmployeeModel ToModel(EmployeeEntity employee)
        {
	        
	        _orderMapper = new OrderMapper();
            EmployeeFactory factory = new EmployeeFactory();
            EmployeeModel convertedEmployee = factory.GetEmployee(employee.EmployeeSpeciality.Speciality);
            convertedEmployee.Id = employee.Id;
            convertedEmployee.Age = employee.Age;
            convertedEmployee.Firstname = employee.Firstname;
            convertedEmployee.Lastname = employee.Lastname;
            convertedEmployee.Orders = employee.Orders
                .Select(orderEntity => _orderMapper.ToModel(orderEntity))
                .ToList();
            convertedEmployee.SpecialityId = employee.EmployeeSpeciality.Id;
            convertedEmployee.LoadedHours = (employee.Orders.Count != 0
	            ? employee.Orders.Select(order =>
			            order.EstimateProcessTime)
		            .Aggregate((firstSpan, secondSpan) =>
			            firstSpan + secondSpan) 
	            : new TimeSpan(0, 0, 0)) + employee.LoadedHours;
            return convertedEmployee;
        }
    }
}
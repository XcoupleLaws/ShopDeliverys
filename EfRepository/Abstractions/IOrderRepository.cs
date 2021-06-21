using System.Collections.Generic;
using Entities;

namespace EfRepository.Abstractions
{
	public interface IOrderRepository : IRepository<OrderEntity, int>{ 
		List<EmployeeEntity> GetRelatedEmployees(OrderEntity order);
	}
}
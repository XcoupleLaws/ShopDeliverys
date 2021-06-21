using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EfRepository.Abstractions;
using Entities;

namespace EfRepository.Repositories
{
	public class OrderRepository: GenericRepository<OrderEntity>, IOrderRepository
	{
		public OrderRepository(ShopContext dataContext, DbSet<OrderEntity> dataTable) : base(dataContext, dataTable)
		{
			
		}
		public List<EmployeeEntity> GetRelatedEmployees(OrderEntity order) =>
			_dataContext.Set<EmployeeEntity>()
				.Where(employee => 
					employee.Id == order.DriverId || employee.Id == order.ManagerId)
				.ToList();
	}
}
using System.Data.Entity;
using EfRepository.Abstractions;
using Entities;

namespace EfRepository.Repositories
{
	public class OrderRepository: GenericRepository<OrderEntity>, IOrderRepository
	{
		public OrderRepository(ShopContext dataContext, DbSet<OrderEntity> dataTable) : base(dataContext, dataTable) 
		{  }
	}
}